using System;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class OyuncuEkleFormu : Form
    {
        public OyuncuEkleFormu()
        {
            InitializeComponent();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string kullaniciAdi = txtKullaniciAdi.Text.Trim();
            string email = txtEmail.Text.Trim();
            string favoriOyunlar = txtFavoriOyunlar.Text.Trim();

            if (string.IsNullOrEmpty(kullaniciAdi) || string.IsNullOrEmpty(email))
            {
                MessageBox.Show("Kullanıcı adı ve e-posta alanları boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string query = "INSERT INTO Kullanici (kullanici_adi, email, favori_oyunlar) VALUES (@kullanici_adi, @email, @favori_oyunlar)";
            DatabaseHelper.ExecuteNonQuery(query,
                new NpgsqlParameter("@kullanici_adi", kullaniciAdi),
                new NpgsqlParameter("@email", email),
                new NpgsqlParameter("@favori_oyunlar", favoriOyunlar));

            MessageBox.Show("Oyuncu başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}