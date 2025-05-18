namespace EsportsApp
{
    partial class TurnuvaKatilimKayitlariFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvKatilimKayitlari;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Button btnGeri;

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
            this.dgvKatilimKayitlari = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.btnGeri = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatilimKayitlari)).BeginInit();
            this.SuspendLayout();

            // DataGridView
            this.dgvKatilimKayitlari.Location = new System.Drawing.Point(12, 12);
            this.dgvKatilimKayitlari.Name = "dgvKatilimKayitlari";
            this.dgvKatilimKayitlari.Size = new System.Drawing.Size(760, 400);
            this.dgvKatilimKayitlari.TabIndex = 0;

            // Add Button
            this.btnEkle.Text = "Ekle";
            this.btnEkle.Location = new System.Drawing.Point(12, 420);
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            // Edit Button
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.Location = new System.Drawing.Point(90, 420);
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);

            // Delete Button
            this.btnSil.Text = "Sil";
            this.btnSil.Location = new System.Drawing.Point(168, 420);
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // Back Button
            this.btnGeri.Text = "Geri";
            this.btnGeri.Location = new System.Drawing.Point(246, 420);
            this.btnGeri.Click += new System.EventHandler((s, e) => this.Close());

            // Form Settings
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.dgvKatilimKayitlari);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnGeri);
            this.Text = "Turnuva Katılım Kayıtları";
            ((System.ComponentModel.ISupportInitialize)(this.dgvKatilimKayitlari)).EndInit();
            this.ResumeLayout(false);
        }
    }
}