namespace EsportsApp
{
    partial class OyuncuEkleDuzenleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.CheckedListBox checkedListBoxFavoriOyunlar;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFavoriOyunlar;
        private System.Windows.Forms.Button btnKaydet;

        // Şifre alanı sadece ekleme modunda olacak
        private System.Windows.Forms.TextBox txtSifre;
        private System.Windows.Forms.Label lblSifre;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtKullaniciAdi = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.checkedListBoxFavoriOyunlar = new System.Windows.Forms.CheckedListBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFavoriOyunlar = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();

            // Şifre alanı sadece oyuncu ekleme modunda gösterilecek
            this.txtSifre = new System.Windows.Forms.TextBox();
            this.lblSifre = new System.Windows.Forms.Label();

            // txtKullaniciAdi
            this.txtKullaniciAdi.Location = new System.Drawing.Point(110, 20);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 20);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(110, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);

            // txtSifre (sadece ekleme modunda)
            this.txtSifre.Location = new System.Drawing.Point(110, 100);
            this.txtSifre.Name = "txtSifre";
            this.txtSifre.PasswordChar = '*';
            this.txtSifre.Size = new System.Drawing.Size(200, 20);

            // checkedListBoxFavoriOyunlar
            this.checkedListBoxFavoriOyunlar.Location = new System.Drawing.Point(110, 140);
            this.checkedListBoxFavoriOyunlar.Items.AddRange(new object[] {
                "League of Legends",
                "Valorant",
                "CS:GO",
                "Dota 2",
                "PUBG",
                "Fortnite"
            });
            this.checkedListBoxFavoriOyunlar.Size = new System.Drawing.Size(200, 100);

            // Labels
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(20, 23);
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";

            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 63);
            this.lblEmail.Text = "E-posta:";

            this.lblSifre.AutoSize = true;
            this.lblSifre.Location = new System.Drawing.Point(20, 103);
            this.lblSifre.Text = "Şifre:";

            this.lblFavoriOyunlar.AutoSize = true;
            this.lblFavoriOyunlar.Location = new System.Drawing.Point(20, 143);
            this.lblFavoriOyunlar.Text = "Favori Oyunlar:";

            // Kaydet Butonu
            this.btnKaydet.Location = new System.Drawing.Point(110, 260);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // Form Özellikleri
            this.ClientSize = new System.Drawing.Size(350, 310);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.checkedListBoxFavoriOyunlar);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFavoriOyunlar);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.txtSifre);
            this.Controls.Add(this.lblSifre);
            this.Text = "Oyuncu Ekle/Düzenle";
            this.Load += new System.EventHandler(this.OyuncuEkleDuzenleFormu_Load);
        }
    }
}