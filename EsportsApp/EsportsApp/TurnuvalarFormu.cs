using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class TurnuvalarFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";

        public TurnuvalarFormu()
        {
            InitializeComponent();
            LoadTurnuvalar(null, null); // İlk yükleme için çağrı
        }

        private void LoadTurnuvalar(object sender, EventArgs e) // EventHandler uyumlu imza
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT turnuva_adi, tarih, aciklama FROM Turnuvalar";
                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvTurnuvalar.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            var form = new TurnuvaEkleDuzenleFormu();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTurnuvalar(null, null); // Yeniden yükleme
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvTurnuvalar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz turnuvayı seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvTurnuvalar.CurrentRow;
            string turnuvaAdi = selectedRow.Cells["turnuva_adi"].Value.ToString();
            string tarih = selectedRow.Cells["tarih"].Value.ToString();
            string aciklama = selectedRow.Cells["aciklama"].Value.ToString();

            var form = new TurnuvaEkleDuzenleFormu(turnuvaAdi, tarih, aciklama);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadTurnuvalar(null, null); // Yeniden yükleme
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvTurnuvalar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz turnuvayı seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Seçili turnuvayı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            string turnuvaAdi = dgvTurnuvalar.CurrentRow.Cells["turnuva_adi"].Value.ToString();

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Turnuvalar WHERE turnuva_adi = @TurnuvaAdi";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TurnuvaAdi", turnuvaAdi);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Turnuva başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadTurnuvalar(null, null); // Yeniden yükleme
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}