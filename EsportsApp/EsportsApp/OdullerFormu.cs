using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class OdullerFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";

        public OdullerFormu()
        {
            InitializeComponent();
            LoadOduller();
        }

        private void LoadOduller()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            tod.odul_id AS ""Ödül ID"",
                            t.turnuva_adi AS ""Turnuva Adı"",
                            tod.odul_miktari AS ""Ödül Miktarı"",
                            tod.odul_turu AS ""Ödül Türü""
                        FROM TurnuvaOdulleri tod
                        JOIN Turnuvalar t ON tod.turnuva_id = t.turnuva_id
                        ORDER BY t.tarih DESC;
                    ";

                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        dgvOduller.DataSource = dataTable;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödüller yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnDuzenle_Click(object sender, EventArgs e)
        {
            if (dgvOduller.SelectedRows.Count > 0)
            {
                int odulId = Convert.ToInt32(dgvOduller.SelectedRows[0].Cells["Ödül ID"].Value);
                OdulDuzenleFormu duzenleFormu = new OdulDuzenleFormu(odulId);
                if (duzenleFormu.ShowDialog() == DialogResult.OK)
                {
                    LoadOduller();
                }
            }
            else
            {
                MessageBox.Show("Lütfen düzenlemek için bir ödül seçin.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
    }
}