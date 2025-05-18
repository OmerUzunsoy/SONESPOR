using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class TurnuvaKatilimEkleFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";
        private int? katilimId = null;

        public TurnuvaKatilimEkleFormu()
        {
            InitializeComponent();
            LoadComboBoxes();
        }

        public TurnuvaKatilimEkleFormu(int katilimId)
        {
            InitializeComponent();
            this.katilimId = katilimId;
            LoadComboBoxes();
            LoadKatilimDetails();
        }

        private void LoadComboBoxes()
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    // Kullanıcıları Yükle
                    var kullaniciQuery = "SELECT kullanici_id, kullanici_adi FROM Kullanici";
                    using (var adapter = new NpgsqlDataAdapter(kullaniciQuery, connection))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbKullanici.DataSource = dataTable;
                        cmbKullanici.DisplayMember = "kullanici_adi";
                        cmbKullanici.ValueMember = "kullanici_id";
                    }

                    // Turnuvaları Yükle
                    var turnuvaQuery = "SELECT turnuva_id, turnuva_adi FROM Turnuvalar";
                    using (var adapter = new NpgsqlDataAdapter(turnuvaQuery, connection))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbTurnuva.DataSource = dataTable;
                        cmbTurnuva.DisplayMember = "turnuva_adi";
                        cmbTurnuva.ValueMember = "turnuva_id";
                    }

                    // Takımları Yükle
                    var takimQuery = "SELECT takim_id, takim_adi FROM Takimlar";
                    using (var adapter = new NpgsqlDataAdapter(takimQuery, connection))
                    {
                        var dataTable = new DataTable();
                        adapter.Fill(dataTable);
                        cmbTakim.DataSource = dataTable;
                        cmbTakim.DisplayMember = "takim_adi";
                        cmbTakim.ValueMember = "takim_id";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veriler yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadKatilimDetails()
        {
            if (katilimId == null) return;

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();
                    string query = @"
                        SELECT 
                            kullanici_id, 
                            turnuva_id, 
                            takim_id, 
                            bireysel
                        FROM TurnuvaKatilim 
                        WHERE katilim_id = @katilimId";

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@katilimId", katilimId);

                        using (var reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                cmbKullanici.SelectedValue = reader["kullanici_id"];
                                cmbTurnuva.SelectedValue = reader["turnuva_id"];
                                cmbTakim.SelectedValue = reader["takim_id"];
                                chkBireysel.Checked = Convert.ToBoolean(reader["bireysel"]);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt detayları yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query;

                    if (katilimId == null)
                    {
                        // Yeni kayıt ekle
                        query = @"
                            INSERT INTO TurnuvaKatilim (kullanici_id, turnuva_id, takim_id, bireysel) 
                            VALUES (@kullaniciId, @turnuvaId, @takimId, @bireysel)";
                    }
                    else
                    {
                        // Mevcut kaydı güncelle
                        query = @"
                            UPDATE TurnuvaKatilim 
                            SET kullanici_id = @kullaniciId, 
                                turnuva_id = @turnuvaId, 
                                takim_id = @takimId, 
                                bireysel = @bireysel 
                            WHERE katilim_id = @katilimId";
                    }

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@kullaniciId", cmbKullanici.SelectedValue);
                        command.Parameters.AddWithValue("@turnuvaId", cmbTurnuva.SelectedValue);
                        command.Parameters.AddWithValue("@takimId", cmbTakim.SelectedValue);
                        command.Parameters.AddWithValue("@bireysel", chkBireysel.Checked);

                        if (katilimId != null)
                        {
                            command.Parameters.AddWithValue("@katilimId", katilimId);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Kayıt başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Kayıt kaydedilirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIptal_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}