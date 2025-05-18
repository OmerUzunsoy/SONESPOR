namespace EsportsApp
{
    partial class OyuncuEkleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtKullaniciAdi;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtFavoriOyunlar;
        private System.Windows.Forms.Label lblKullaniciAdi;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblFavoriOyunlar;
        private System.Windows.Forms.Button btnKaydet;

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
            this.txtFavoriOyunlar = new System.Windows.Forms.TextBox();
            this.lblKullaniciAdi = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.lblFavoriOyunlar = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();

            // txtKullaniciAdi
            this.txtKullaniciAdi.Location = new System.Drawing.Point(110, 20);
            this.txtKullaniciAdi.Name = "txtKullaniciAdi";
            this.txtKullaniciAdi.Size = new System.Drawing.Size(200, 20);

            // txtEmail
            this.txtEmail.Location = new System.Drawing.Point(110, 60);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(200, 20);

            // txtFavoriOyunlar
            this.txtFavoriOyunlar.Location = new System.Drawing.Point(110, 100);
            this.txtFavoriOyunlar.Name = "txtFavoriOyunlar";
            this.txtFavoriOyunlar.Size = new System.Drawing.Size(200, 20);

            // lblKullaniciAdi
            this.lblKullaniciAdi.AutoSize = true;
            this.lblKullaniciAdi.Location = new System.Drawing.Point(20, 23);
            this.lblKullaniciAdi.Text = "Kullanıcı Adı:";

            // lblEmail
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(20, 63);
            this.lblEmail.Text = "E-posta:";

            // lblFavoriOyunlar
            this.lblFavoriOyunlar.AutoSize = true;
            this.lblFavoriOyunlar.Location = new System.Drawing.Point(20, 103);
            this.lblFavoriOyunlar.Text = "Favori Oyunlar:";

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(110, 140);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // OyuncuEkleFormu
            this.ClientSize = new System.Drawing.Size(350, 200);
            this.Controls.Add(this.txtKullaniciAdi);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtFavoriOyunlar);
            this.Controls.Add(this.lblKullaniciAdi);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblFavoriOyunlar);
            this.Controls.Add(this.btnKaydet);
            this.Text = "Oyuncu Ekle";
        }
    }
}