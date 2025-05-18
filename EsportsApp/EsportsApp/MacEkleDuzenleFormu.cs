using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class MacEkleDuzenleFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";
        private readonly int? macId;

        public MacEkleDuzenleFormu()
        {
            InitializeComponent();
            this.Text = "Yeni Maç Ekle";
            LoadTakimlar();
            LoadTurnuvalar();
            LoadHaritalar();
        }

        public MacEkleDuzenleFormu(int macId, string takim1, string takim2, string tarih, string saat, string harita, string turnuvaAdi)
        {
            InitializeComponent();
            this.Text = "Maçı Düzenle";
            this.macId = macId;

            LoadTakimlar();
            LoadTurnuvalar();
            LoadHaritalar();

            cmbTakim1.SelectedItem = takim1;
            cmbTakim2.SelectedItem = takim2;
            dtpTarih.Value = DateTime.Parse(tarih);
            cmbSaat.SelectedItem = saat;
            cmbHarita.SelectedItem = harita;
            cmbTurnuva.SelectedItem = turnuvaAdi;
        }

        private void LoadTakimlar()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT takim_adi FROM Takimlar";
                    using (var command = new NpgsqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbTakim1.Items.Add(reader.GetString(0));
                            cmbTakim2.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Takımlar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadTurnuvalar()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT turnuva_adi FROM Turnuvalar";
                    using (var command = new NpgsqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbTurnuva.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Turnuvalar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadHaritalar()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = "SELECT DISTINCT harita FROM Maclar WHERE harita IS NOT NULL";
                    using (var command = new NpgsqlCommand(query, connection))
                    using (var reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            cmbHarita.Items.Add(reader.GetString(0));
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Haritalar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string takim1 = cmbTakim1.SelectedItem?.ToString();
            string takim2 = cmbTakim2.SelectedItem?.ToString();
            string turnuva = cmbTurnuva.SelectedItem?.ToString();
            string saatStr = cmbSaat.SelectedItem?.ToString();
            string harita = cmbHarita.SelectedItem?.ToString();
            DateTime tarih = dtpTarih.Value;

            if (string.IsNullOrEmpty(takim1) || string.IsNullOrEmpty(takim2) || string.IsNullOrEmpty(turnuva) || string.IsNullOrEmpty(saatStr) || string.IsNullOrEmpty(harita))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                // Saatin `TimeSpan` türüne dönüştürülmesi
                TimeSpan saat = TimeSpan.Parse(saatStr);

                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    if (macId.HasValue) // Düzenleme işlemi için
                    {
                        string updateQuery = @"
                            UPDATE Maclar
                            SET 
                                takim1_id = (SELECT takim_id FROM Takimlar WHERE takim_adi = @Takim1),
                                takim2_id = (SELECT takim_id FROM Takimlar WHERE takim_adi = @Takim2),
                                tarih = @Tarih,
                                saat = @Saat,
                                harita = @Harita,
                                turnuva_id = (SELECT turnuva_id FROM Turnuvalar WHERE turnuva_adi = @TurnuvaAdi)
                            WHERE mac_id = @MacId;
                        ";

                        using (var command = new NpgsqlCommand(updateQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Takim1", takim1);
                            command.Parameters.AddWithValue("@Takim2", takim2);
                            command.Parameters.AddWithValue("@Tarih", tarih);
                            command.Parameters.AddWithValue("@Saat", saat); // TimeSpan olarak ekleniyor
                            command.Parameters.AddWithValue("@Harita", harita);
                            command.Parameters.AddWithValue("@TurnuvaAdi", turnuva);
                            command.Parameters.AddWithValue("@MacId", macId.Value);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Maç başarıyla güncellendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Yeni kayıt eklemek için
                    {
                        string insertQuery = @"
                            INSERT INTO Maclar (takim1_id, takim2_id, tarih, saat, harita, turnuva_id)
                            VALUES (
                                (SELECT takim_id FROM Takimlar WHERE takim_adi = @Takim1),
                                (SELECT takim_id FROM Takimlar WHERE takim_adi = @Takim2),
                                @Tarih,
                                @Saat,
                                @Harita,
                                (SELECT turnuva_id FROM Turnuvalar WHERE turnuva_adi = @TurnuvaAdi)
                            );
                        ";

                        using (var command = new NpgsqlCommand(insertQuery, connection))
                        {
                            command.Parameters.AddWithValue("@Takim1", takim1);
                            command.Parameters.AddWithValue("@Takim2", takim2);
                            command.Parameters.AddWithValue("@Tarih", tarih);
                            command.Parameters.AddWithValue("@Saat", saat); // TimeSpan olarak ekleniyor
                            command.Parameters.AddWithValue("@Harita", harita);
                            command.Parameters.AddWithValue("@TurnuvaAdi", turnuva);

                            command.ExecuteNonQuery();
                        }

                        MessageBox.Show("Yeni maç başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}