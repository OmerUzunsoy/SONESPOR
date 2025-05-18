namespace EsportsApp
{
    partial class TakimEkleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTakimAdi;
        private System.Windows.Forms.TextBox txtKaptan;
        private System.Windows.Forms.Label lblTakimAdi;
        private System.Windows.Forms.Label lblKaptan;
        private System.Windows.Forms.Label lblBosOyuncular;
        private System.Windows.Forms.Label lblSecilenOyuncular;
        private System.Windows.Forms.ListBox listBoxBosOyuncular;
        private System.Windows.Forms.ListBox listBoxSecilenOyuncular;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnCikar;
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
            this.txtTakimAdi = new System.Windows.Forms.TextBox();
            this.txtKaptan = new System.Windows.Forms.TextBox();
            this.lblTakimAdi = new System.Windows.Forms.Label();
            this.lblKaptan = new System.Windows.Forms.Label();
            this.lblBosOyuncular = new System.Windows.Forms.Label();
            this.lblSecilenOyuncular = new System.Windows.Forms.Label();
            this.listBoxBosOyuncular = new System.Windows.Forms.ListBox();
            this.listBoxSecilenOyuncular = new System.Windows.Forms.ListBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnCikar = new System.Windows.Forms.Button();
            this.btnKaydet = new System.Windows.Forms.Button();

            // txtTakimAdi
            this.txtTakimAdi.Location = new System.Drawing.Point(110, 20);
            this.txtTakimAdi.Name = "txtTakimAdi";
            this.txtTakimAdi.Size = new System.Drawing.Size(200, 20);

            // txtKaptan
            this.txtKaptan.Location = new System.Drawing.Point(110, 60);
            this.txtKaptan.Name = "txtKaptan";
            this.txtKaptan.Size = new System.Drawing.Size(200, 20);

            // lblTakimAdi
            this.lblTakimAdi.AutoSize = true;
            this.lblTakimAdi.Location = new System.Drawing.Point(20, 23);
            this.lblTakimAdi.Name = "lblTakimAdi";
            this.lblTakimAdi.Size = new System.Drawing.Size(59, 13);
            this.lblTakimAdi.Text = "Takım Adı:";

            // lblKaptan
            this.lblKaptan.AutoSize = true;
            this.lblKaptan.Location = new System.Drawing.Point(20, 63);
            this.lblKaptan.Name = "lblKaptan";
            this.lblKaptan.Size = new System.Drawing.Size(45, 13);
            this.lblKaptan.Text = "Kaptan:";

            // lblBosOyuncular
            this.lblBosOyuncular.AutoSize = true;
            this.lblBosOyuncular.Location = new System.Drawing.Point(20, 100);
            this.lblBosOyuncular.Name = "lblBosOyuncular";
            this.lblBosOyuncular.Size = new System.Drawing.Size(85, 13);
            this.lblBosOyuncular.Text = "Boşta Oyuncular:";

            // lblSecilenOyuncular
            this.lblSecilenOyuncular.AutoSize = true;
            this.lblSecilenOyuncular.Location = new System.Drawing.Point(250, 100);
            this.lblSecilenOyuncular.Name = "lblSecilenOyuncular";
            this.lblSecilenOyuncular.Size = new System.Drawing.Size(94, 13);
            this.lblSecilenOyuncular.Text = "Seçilen Oyuncular:";

            // listBoxBosOyuncular
            this.listBoxBosOyuncular.Location = new System.Drawing.Point(20, 120);
            this.listBoxBosOyuncular.Name = "listBoxBosOyuncular";
            this.listBoxBosOyuncular.Size = new System.Drawing.Size(200, 150);

            // listBoxSecilenOyuncular
            this.listBoxSecilenOyuncular.Location = new System.Drawing.Point(250, 120);
            this.listBoxSecilenOyuncular.Name = "listBoxSecilenOyuncular";
            this.listBoxSecilenOyuncular.Size = new System.Drawing.Size(200, 150);

            // btnEkle
            this.btnEkle.Location = new System.Drawing.Point(230, 140);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(20, 25);
            this.btnEkle.Text = ">";
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            // btnCikar
            this.btnCikar.Location = new System.Drawing.Point(230, 180);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(20, 25);
            this.btnCikar.Text = "<";
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(160, 290);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(120, 30);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // TakimEkleFormu
            this.ClientSize = new System.Drawing.Size(480, 340);
            this.Controls.Add(this.txtTakimAdi);
            this.Controls.Add(this.txtKaptan);
            this.Controls.Add(this.lblTakimAdi);
            this.Controls.Add(this.lblKaptan);
            this.Controls.Add(this.lblBosOyuncular);
            this.Controls.Add(this.lblSecilenOyuncular);
            this.Controls.Add(this.listBoxBosOyuncular);
            this.Controls.Add(this.listBoxSecilenOyuncular);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.btnKaydet);
            this.Text = "Takım Ekle";
            this.Load += new System.EventHandler(this.TakimEkleFormu_Load);
        }
    }
}