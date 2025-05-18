using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class MaclarFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";

        public MaclarFormu()
        {
            InitializeComponent();
            LoadMaclar(); // Maçları yükle
        }

        private void LoadMaclar()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            m.mac_id AS ""Maç ID"", 
                            t1.takim_adi AS ""Takım 1"", 
                            t2.takim_adi AS ""Takım 2"", 
                            m.tarih AS ""Tarih"", 
                            m.saat AS ""Saat"", 
                            m.harita AS ""Harita"", 
                            tr.turnuva_adi AS ""Turnuva Adı""
                        FROM Maclar m
                        JOIN Takimlar t1 ON m.takim1_id = t1.takim_id
                        JOIN Takimlar t2 ON m.takim2_id = t2.takim_id
                        LEFT JOIN Turnuvalar tr ON m.turnuva_id = tr.turnuva_id
                        ORDER BY m.tarih, m.saat;
                    ";

                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvMaclar.DataSource = dataTable;
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
            var form = new MacEkleDuzenleFormu();
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMaclar();
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvMaclar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen düzenlemek istediğiniz maçı seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var selectedRow = dgvMaclar.CurrentRow;
            int macId = Convert.ToInt32(selectedRow.Cells["Maç ID"].Value);
            string takim1 = selectedRow.Cells["Takım 1"].Value.ToString();
            string takim2 = selectedRow.Cells["Takım 2"].Value.ToString();
            string tarih = selectedRow.Cells["Tarih"].Value.ToString();
            string saat = selectedRow.Cells["Saat"].Value.ToString();
            string harita = selectedRow.Cells["Harita"].Value.ToString();
            string turnuvaAdi = selectedRow.Cells["Turnuva Adı"].Value?.ToString();

            var form = new MacEkleDuzenleFormu(macId, takim1, takim2, tarih, saat, harita, turnuvaAdi);
            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadMaclar();
            }
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            if (dgvMaclar.CurrentRow == null)
            {
                MessageBox.Show("Lütfen silmek istediğiniz maçı seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var result = MessageBox.Show("Seçili maçı silmek istediğinize emin misiniz?", "Onay", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result != DialogResult.Yes) return;

            int macId = Convert.ToInt32(dgvMaclar.CurrentRow.Cells["Maç ID"].Value);

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "DELETE FROM Maclar WHERE mac_id = @MacId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@MacId", macId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Maç başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadMaclar();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}