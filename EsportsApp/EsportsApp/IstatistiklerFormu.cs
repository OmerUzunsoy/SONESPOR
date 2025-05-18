using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class IstatistiklerFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";

        public IstatistiklerFormu()
        {
            InitializeComponent();
            LoadTurnuvalar();
        }

        private void LoadTurnuvalar()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT turnuva_id, turnuva_adi FROM Turnuvalar";
                    using (var adapter = new NpgsqlDataAdapter(query, connection))
                    {
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbTurnuvalar.DataSource = dataTable;
                        cmbTurnuvalar.DisplayMember = "turnuva_adi";
                        cmbTurnuvalar.ValueMember = "turnuva_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Turnuvalar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIstatistikYukle_Click(object sender, EventArgs e)
        {
            if (cmbTurnuvalar.SelectedValue != null)
            {
                int turnuvaId = Convert.ToInt32(cmbTurnuvalar.SelectedValue);
                LoadIstatistikler(turnuvaId);
            }
        }

        private void LoadIstatistikler(int turnuvaId)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            t.turnuva_adi AS ""Turnuva Adı"",
                            ts.derece AS ""Derece"",
                            ts.skor AS ""Skor"",
                            tod.odul_miktari AS ""Ödül Miktarı"",
                            tod.odul_turu AS ""Ödül Türü""
                        FROM Turnuvalar t
                        JOIN TurnuvaSonuclari ts ON t.turnuva_id = ts.turnuva_id
                        JOIN TurnuvaOdulleri tod ON t.turnuva_id = tod.turnuva_id
                        WHERE t.turnuva_id = @TurnuvaId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@TurnuvaId", turnuvaId);

                        using (var adapter = new NpgsqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            adapter.Fill(dataTable);
                            dgvIstatistikler.DataSource = dataTable;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"İstatistikler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}