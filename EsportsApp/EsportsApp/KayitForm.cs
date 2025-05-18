using System;
using System.Data;
using System.Drawing;
using System.Text.RegularExpressions;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class KayitForm : Form
    {
        private Form _girisForm; // Giriş formunun referansı

        public KayitForm(Form girisForm)
        {
            InitializeComponent();
            this.BackColor = Color.LightSteelBlue; // Giriş ekranı temasını yansıtan arka plan rengi
            this.StartPosition = FormStartPosition.CenterScreen; // Form ekranının ortasında açılması için
            _girisForm = girisForm; // Giriş formunu referans olarak tutuyoruz
            this.FormClosing += KayitForm_FormClosing; // Form kapanma olayını ekliyoruz
        }

        private void KayitForm_Load(object sender, EventArgs e)
        {
            // Sağ alt köşeye "Ömer Uzunsoy" yazısı ekle
            Label lblOmerUzunsoy = new Label
            {
                Text = "Ömer Uzunsoy",
                AutoSize = true,
                ForeColor = Color.Gray,
                Font = new Font("Arial", 10, FontStyle.Regular),
                Location = new Point(this.ClientSize.Width - 120, this.ClientSize.Height - 30),
                Anchor = AnchorStyles.Bottom | AnchorStyles.Right
            };
            this.Controls.Add(lblOmerUzunsoy);

            // Giriş formunu gizle
            if (_girisForm != null)
            {
                _girisForm.Hide(); // Giriş formunu gizle
            }

            // Favori oyunları CheckedListBox'a yükle
            YukleFavoriOyunlar();
        }

        private void YukleFavoriOyunlar()
        {
            string query = "SELECT oyun_adi FROM Oyunlar"; // Oyunlar tablosundaki oyun isimlerini al
            using (NpgsqlConnection conn = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            while (reader.Read())
                            {
                                checkedListBoxFavoriOyunlar.Items.Add(reader.GetString(0)); // CheckedListBox'a oyun adını ekle
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Oyunlar yüklenirken bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnKaydiTamamla_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKayitKullaniciAdi.Text.Trim();
            string email = txtKayitEmail.Text.Trim();
            string sifre = txtKayitSifre.Text.Trim();
            string favoriOyunlar = GetSelectedFavoriOyunlar(); // Seçilen favori oyunları al

            // E-posta formatını kontrol et
            if (!IsValidEmail(email))
            {
                MessageBox.Show("Lütfen geçerli bir e-posta adresi girin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre) || string.IsNullOrEmpty(favoriOyunlar))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun ve en az bir favori oyun seçin!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Kullanıcı adı kontrolü
            if (KullaniciAdiVarMi(kullaniciAdi))
            {
                MessageBox.Show("Bu kullanıcı adı zaten alınmış! Lütfen farklı bir kullanıcı adı girin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO kullanici (kullanici_adi, email, sifre, favori_oyunlar) VALUES (@KullaniciAdi, @Email, @Sifre, @FavoriOyunlar)";
            try
            {
                var parameters = new[]
                {
                    new NpgsqlParameter("@KullaniciAdi", kullaniciAdi),
                    new NpgsqlParameter("@Email", email),
                    new NpgsqlParameter("@Sifre", sifre),
                    new NpgsqlParameter("@FavoriOyunlar", favoriOyunlar)
                };

                int result = DatabaseHelper.ExecuteNonQuery(query, parameters);

                if (result > 0)
                {
                    MessageBox.Show("Kayıt başarılı! Şimdi giriş yapabilirsiniz.", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    if (_girisForm != null)
                    {
                        _girisForm.Show(); // Giriş formunu tekrar göster
                    }

                    this.Close(); // Kayıt formunu kapat
                }
                else
                {
                    MessageBox.Show("Kayıt başarısız! Lütfen tekrar deneyin.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool KullaniciAdiVarMi(string kullaniciAdi)
        {
            string query = "SELECT COUNT(*) FROM kullanici WHERE kullanici_adi = @KullaniciAdi";
            using (NpgsqlConnection conn = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@KullaniciAdi", kullaniciAdi);
                        int count = Convert.ToInt32(cmd.ExecuteScalar()); // Kullanıcı adı sayısını al
                        return count > 0; // Eğer 1 veya daha fazla varsa true döner
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return true; // Hata durumunda işlem iptal edilsin
                }
            }
        }

        private string GetSelectedFavoriOyunlar()
        {
            var selectedOyunlar = new System.Collections.Generic.List<string>();
            foreach (var item in checkedListBoxFavoriOyunlar.CheckedItems)
            {
                selectedOyunlar.Add(item.ToString());
            }
            return string.Join(",", selectedOyunlar); // Virgülle ayrılmış string döner
        }

        private bool IsValidEmail(string email)
        {
            // Basit bir e-posta doğrulama regex'i
            string emailRegex = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailRegex);
        }

        private void KayitForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Giriş formunu tekrar göster
            if (_girisForm != null && !_girisForm.IsDisposed)
            {
                _girisForm.Show();
            }
            else
            {
                // Eğer giriş formu kapalıysa uygulamayı tamamen kapat
                Application.Exit();
            }
        }
    }
}