using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class TurnuvaKatilimKayitlariFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";

        public TurnuvaKatilimKayitlariFormu()
        {
            InitializeComponent();
            LoadKatilimKayitlari();
        }

        private void LoadKatilimKayitlari()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            tk.katilim_id,
                            t.turnuva_adi AS ""Turnuva Adı"",
                            tm.takim_adi AS ""Takım Adı"",
                            k.kullanici_adi AS ""Kullanıcı Adı"",
                            tk.bireysel AS ""Bireysel Katılım"",
                            t.tarih AS ""Katılım Tarihi""
                        FROM TurnuvaKatilim tk
                        LEFT JOIN Turnuvalar t ON tk.turnuva_id = t.turnuva_id
                        LEFT JOIN Takimlar tm ON tk.takim_id = tm.takim_id
                        LEFT JOIN Kullanici k ON tk.kullanici_id = k.kullanici_id
                        ORDER BY t.tarih DESC;
                    ";

                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvKatilimKayitlari.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıtlar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            // Yeni kayıt eklemek için bir form açılır
            TurnuvaKatilimEkleFormu ekleFormu = new TurnuvaKatilimEkleFormu();
            if (ekleFormu.ShowDialog() == DialogResult.OK)
            {
                LoadKatilimKayitlari();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvKatilimKayitlari.SelectedRows.Count > 0)
            {
                int katilimId = Convert.ToInt32(dgvKatilimKayitlari.SelectedRows[0].Cells["katilim_id"].Value);
                TurnuvaKatilimEkleFormu duzenleFormu = new TurnuvaKatilimEkleFormu(katilimId);
                if (duzenleFormu.ShowDialog() == DialogResult.OK)
                {
                    LoadKatilimKayitlari();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir kayıt seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvKatilimKayitlari.SelectedRows.Count > 0)
            {
                int katilimId = Convert.ToInt32(dgvKatilimKayitlari.SelectedRows[0].Cells["katilim_id"].Value);

                try
                {
                    using (var connection = new NpgsqlConnection(connectionString))
                    {
                        connection.Open();
                        string query = "DELETE FROM TurnuvaKatilim WHERE katilim_id = @KatilimID";

                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@KatilimID", katilimId);
                            command.ExecuteNonQuery();
                        }
                    }

                    MessageBox.Show("Kayıt başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    LoadKatilimKayitlari();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Kayıt silinirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Lütfen silmek için bir kayıt seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}