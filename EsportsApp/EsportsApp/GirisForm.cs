using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class GirisForm : Form
    {
        public GirisForm()
        {
            InitializeComponent();
            txtGirisKullaniciAdi.KeyDown += txtGirisKullaniciAdi_KeyDown;
            txtGirisEmail.KeyDown += txtGirisEmail_KeyDown;
            txtGirisSifre.KeyDown += txtGirisSifre_KeyDown;
            this.BackColor = Color.LightSteelBlue; // Arka plan rengi
            this.StartPosition = FormStartPosition.CenterScreen; // Form ekranın ortasında açılır

            // Form kapanışında uygulamayı tamamen sonlandır
            this.FormClosed += GirisForm_FormClosed;
        }

        private void GirisForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Eğer giriş formu kapanırsa, uygulamayı tamamen kapat
            Application.Exit();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // İsteğe bağlı bir işlem eklenebilir
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // Kayıt Ol butonuna tıklanınca
            KayitForm kayitForm = new KayitForm(this); // Giriş formunu referans olarak gönderiyoruz
            kayitForm.Show();
            this.Hide(); // Giriş formunu gizle
        }

        private void btnGirisYap_Click(object sender, EventArgs e)
        {
            string email = txtGirisEmail.Text.Trim();
            string sifre = txtGirisSifre.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(sifre))
            {
                MessageBox.Show("Lütfen tüm alanları doldurun!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "SELECT * FROM Kullanici WHERE email = @Email AND sifre = @Sifre";
            using (NpgsqlConnection conn = new NpgsqlConnection(DatabaseHelper.ConnectionString))
            {
                try
                {
                    conn.Open();
                    using (NpgsqlCommand cmd = new NpgsqlCommand(query, conn))
                    {
                        cmd.Parameters.AddWithValue("@Email", email);
                        cmd.Parameters.AddWithValue("@Sifre", sifre);

                        using (NpgsqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                MessageBox.Show("Giriş başarılı!", "Başarılı", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                AnaForm anaForm = new AnaForm();
                                anaForm.Show();
                                this.Hide(); // Giriş formunu gizle
                            }
                            else
                            {
                                MessageBox.Show("E-posta veya şifre hatalı!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void GirisForm_Load(object sender, EventArgs e)
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
        }

        // Kullanıcı adı kutusunda Tab'a basınca e-posta kutusuna geç
        private void txtGirisKullaniciAdi_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtGirisEmail.Focus();
            }
        }

        // E-posta kutusunda Tab'a basınca şifre kutusuna geç
        private void txtGirisEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Tab)
            {
                e.SuppressKeyPress = true;
                txtGirisSifre.Focus();
            }
        }

        // Şifre kutusunda Enter'a basınca giriş yap
        private void txtGirisSifre_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btnGirisYap.PerformClick();
            }
        }
    }
}