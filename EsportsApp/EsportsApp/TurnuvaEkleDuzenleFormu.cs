using System;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class TurnuvaEkleDuzenleFormu : Form
    {
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";
        private readonly string originalTurnuvaAdi;
        private readonly DateTime originalTarih;
        private readonly string originalAciklama;

        // Parametresiz Constructor (Yeni Turnuva Ekleme)
        public TurnuvaEkleDuzenleFormu()
        {
            InitializeComponent();
            this.Text = "Turnuva Ekle";
            dtpTarih.Value = DateTime.Now;
        }

        // 3 Parametreli Constructor (Mevcut Turnuvayı Düzenleme)
        public TurnuvaEkleDuzenleFormu(string turnuvaAdi, string tarih, string aciklama)
        {
            InitializeComponent();

            originalTurnuvaAdi = turnuvaAdi; // Orijinal Turnuva Adı
            originalTarih = string.IsNullOrEmpty(tarih) ? DateTime.Now : DateTime.Parse(tarih); // Tarih değeri
            originalAciklama = aciklama; // Orijinal Açıklama

            txtTurnuvaAdi.Text = turnuvaAdi;
            dtpTarih.Value = originalTarih;
            txtAciklama.Text = aciklama;

            this.Text = "Turnuva Düzenle";
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string turnuvaAdi = txtTurnuvaAdi.Text.Trim();
            DateTime tarih = dtpTarih.Value;
            string aciklama = txtAciklama.Text.Trim();

            if (string.IsNullOrEmpty(turnuvaAdi))
            {
                MessageBox.Show("Turnuva adı boş bırakılamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    string query;
                    if (string.IsNullOrEmpty(originalTurnuvaAdi))
                    {
                        // Yeni turnuva ekleme
                        query = "INSERT INTO Turnuvalar (turnuva_adi, tarih, aciklama) VALUES (@adi, @tarih, @aciklama)";
                    }
                    else
                    {
                        // Mevcut turnuvayı güncelleme
                        query = "UPDATE Turnuvalar SET turnuva_adi = @adi, tarih = @tarih, aciklama = @aciklama WHERE turnuva_adi = @originalAdi";
                    }

                    using (var command = new NpgsqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@adi", turnuvaAdi);
                        command.Parameters.AddWithValue("@tarih", tarih);
                        command.Parameters.AddWithValue("@aciklama", aciklama);

                        if (!string.IsNullOrEmpty(originalTurnuvaAdi))
                        {
                            command.Parameters.AddWithValue("@originalAdi", originalTurnuvaAdi);
                        }

                        command.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Turnuva başarıyla kaydedildi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
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