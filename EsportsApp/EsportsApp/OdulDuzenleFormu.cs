using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class OdulDuzenleFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";
        private readonly int odulId;

        public OdulDuzenleFormu(int odulId)
        {
            InitializeComponent();
            this.odulId = odulId;
            LoadOdulDetails();
        }

        private void LoadOdulDetails()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT odul_miktari, odul_turu FROM TurnuvaOdulleri WHERE odul_id = @OdulId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OdulId", odulId);
                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                txtOdulMiktari.Text = reader["odul_miktari"].ToString();
                                txtOdulTuru.Text = reader["odul_turu"].ToString();
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödül detayları yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "UPDATE TurnuvaOdulleri SET odul_miktari = @OdulMiktari, odul_turu = @OdulTuru WHERE odul_id = @OdulId";
                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@OdulMiktari", Convert.ToInt32(txtOdulMiktari.Text));
                        command.Parameters.AddWithValue("@OdulTuru", txtOdulTuru.Text);
                        command.Parameters.AddWithValue("@OdulId", odulId);
                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Ödül başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ödül güncellenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}