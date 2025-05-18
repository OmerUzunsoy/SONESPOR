using System;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class OyuncuEkleDuzenleFormu : Form
    {
        private readonly int? oyuncuId; // Oyuncu ID'si
        private readonly string kullaniciAdi; // Kullanıcı Adı
        private readonly string email; // E-posta
        private readonly string favoriOyunlar; // Favori Oyunlar
        private readonly string connectionString = "Host=localhost;Port=5432;Username=postgres;Password=3455;Database=sonespor";

        // 4 bağımsız değişken alan constructor (oluşturucu) ve varsayılan değerler
        public OyuncuEkleDuzenleFormu(int? oyuncuId = null, string kullaniciAdi = "", string email = "", string favoriOyunlar = "")
        {
            InitializeComponent();
            this.oyuncuId = oyuncuId;
            this.kullaniciAdi = kullaniciAdi;
            this.email = email;
            this.favoriOyunlar = favoriOyunlar;
        }

        private void OyuncuEkleDuzenleFormu_Load(object sender, EventArgs e)
        {
            if (oyuncuId.HasValue) // Eğer düzenleme modundaysa
            {
                // Mevcut bilgileri doldur
                txtKullaniciAdi.Text = kullaniciAdi;
                txtEmail.Text = email;

                // Favori oyunları işaretle
                var favoriOyunlarListesi = favoriOyunlar.Split(',').Select(o => o.Trim()).ToList();
                for (int i = 0; i < checkedListBoxFavoriOyunlar.Items.Count; i++)
                {
                    if (favoriOyunlarListesi.Contains(checkedListBoxFavoriOyunlar.Items[i].ToString()))
                    {
                        checkedListBoxFavoriOyunlar.SetItemChecked(i, true);
                    }
                }

                // Şifre alanını gizle (sadece ekleme ekranında şifre görünür)
                txtSifre.Visible = false;
                lblSifre.Visible = false;
            }
            else
            {
                // Eğer ekleme modundaysa, şifre alanı görünür
                txtSifre.Visible = true;
                lblSifre.Visible = true;
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string favoriOyunlar = string.Join(", ", checkedListBoxFavoriOyunlar.CheckedItems.Cast<string>());

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Kullanıcı adı ve e-posta alanları doldurulmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                using (var connection = new NpgsqlConnection(connectionString))
                {
                    connection.Open();

                    if (oyuncuId.HasValue) // Eğer düzenleme modundaysa
                    {
                        string query = "UPDATE Kullanici SET kullanici_adi = @KullaniciAdi, email = @Email, favori_oyunlar = @FavoriOyunlar WHERE kullanici_id = @Id";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@FavoriOyunlar", favoriOyunlar);
                            command.Parameters.AddWithValue("@Id", oyuncuId.Value);
                            command.ExecuteNonQuery();
                        }
                    }
                    else // Yeni oyuncu ekleme
                    {
                        if (string.IsNullOrEmpty(txtSifre.Text.Trim()))
                        {
                            MessageBox.Show("Şifre alanı doldurulmalıdır.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            return;
                        }

                        string query = "INSERT INTO Kullanici (kullanici_adi, email, sifre, favori_oyunlar) VALUES (@KullaniciAdi, @Email, @Sifre, @FavoriOyunlar)";
                        using (var command = new NpgsqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                            command.Parameters.AddWithValue("@Email", email);
                            command.Parameters.AddWithValue("@Sifre", txtSifre.Text.Trim());
                            command.Parameters.AddWithValue("@FavoriOyunlar", favoriOyunlar);
                            command.ExecuteNonQuery();
                        }
                    }
                }

                MessageBox.Show(oyuncuId.HasValue ? "Oyuncu başarıyla güncellendi." : "Oyuncu başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}