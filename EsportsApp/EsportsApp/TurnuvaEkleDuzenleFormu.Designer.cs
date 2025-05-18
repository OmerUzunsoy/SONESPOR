namespace EsportsApp
{
    partial class TurnuvaEkleDuzenleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtTurnuvaAdi;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.TextBox txtAciklama;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;
        private System.Windows.Forms.Label lblTurnuvaAdi;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblAciklama;

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
            this.txtTurnuvaAdi = new System.Windows.Forms.TextBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.txtAciklama = new System.Windows.Forms.TextBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.lblTurnuvaAdi = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblAciklama = new System.Windows.Forms.Label();
            this.SuspendLayout();

            // txtTurnuvaAdi
            this.txtTurnuvaAdi.Location = new System.Drawing.Point(150, 20);
            this.txtTurnuvaAdi.Name = "txtTurnuvaAdi";
            this.txtTurnuvaAdi.Size = new System.Drawing.Size(200, 20);

            // dtpTarih
            this.dtpTarih.Location = new System.Drawing.Point(150, 60);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 20);

            // txtAciklama
            this.txtAciklama.Location = new System.Drawing.Point(150, 100);
            this.txtAciklama.Multiline = true;
            this.txtAciklama.Name = "txtAciklama";
            this.txtAciklama.Size = new System.Drawing.Size(200, 60);

            // btnKaydet
            this.btnKaydet.Location = new System.Drawing.Point(150, 180);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(80, 30);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // btnIptal
            this.btnIptal.Location = new System.Drawing.Point(270, 180);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(80, 30);
            this.btnIptal.Text = "İptal";
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // lblTurnuvaAdi
            this.lblTurnuvaAdi.Location = new System.Drawing.Point(50, 20);
            this.lblTurnuvaAdi.Text = "Turnuva Adı:";

            // lblTarih
            this.lblTarih.Location = new System.Drawing.Point(50, 60);
            this.lblTarih.Text = "Tarih:";

            // lblAciklama
            this.lblAciklama.Location = new System.Drawing.Point(50, 100);
            this.lblAciklama.Text = "Açıklama:";

            // TurnuvaEkleDuzenleFormu
            this.ClientSize = new System.Drawing.Size(400, 240);
            this.Controls.Add(this.txtTurnuvaAdi);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.txtAciklama);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Controls.Add(this.lblTurnuvaAdi);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.lblAciklama);
            this.Text = "Turnuva Ekle/Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}