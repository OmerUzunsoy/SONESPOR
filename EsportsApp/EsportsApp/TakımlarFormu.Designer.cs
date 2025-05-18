namespace EsportsApp
{
    partial class TakımlarFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblBaslik;
        private System.Windows.Forms.DataGridView dataGridViewTakimlar;
        private System.Windows.Forms.ListBox listBoxBosOyuncular;
        private System.Windows.Forms.Button btnTakimEkle;
        private System.Windows.Forms.Button btnTakimSil;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.Button btnOyuncuCikar;

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
            this.lblBaslik = new System.Windows.Forms.Label();
            this.dataGridViewTakimlar = new System.Windows.Forms.DataGridView();
            this.listBoxBosOyuncular = new System.Windows.Forms.ListBox();
            this.btnTakimEkle = new System.Windows.Forms.Button();
            this.btnTakimSil = new System.Windows.Forms.Button();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.btnOyuncuCikar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakimlar)).BeginInit();
            this.SuspendLayout();

            // lblBaslik
            this.lblBaslik.AutoSize = true;
            this.lblBaslik.Font = new System.Drawing.Font("Arial", 16F, System.Drawing.FontStyle.Bold);
            this.lblBaslik.Location = new System.Drawing.Point(12, 9);
            this.lblBaslik.Name = "lblBaslik";
            this.lblBaslik.Size = new System.Drawing.Size(166, 26);
            this.lblBaslik.TabIndex = 0;
            this.lblBaslik.Text = "Takım Yönetimi";

            // dataGridViewTakimlar
            this.dataGridViewTakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTakimlar.Location = new System.Drawing.Point(15, 50);
            this.dataGridViewTakimlar.Name = "dataGridViewTakimlar";
            this.dataGridViewTakimlar.Size = new System.Drawing.Size(450, 200);

            // listBoxBosOyuncular
            this.listBoxBosOyuncular.FormattingEnabled = true;
            this.listBoxBosOyuncular.Location = new System.Drawing.Point(15, 270);
            this.listBoxBosOyuncular.Name = "listBoxBosOyuncular";
            this.listBoxBosOyuncular.Size = new System.Drawing.Size(450, 95);

            // btnTakimEkle
            this.btnTakimEkle.Location = new System.Drawing.Point(500, 50);
            this.btnTakimEkle.Name = "btnTakimEkle";
            this.btnTakimEkle.Size = new System.Drawing.Size(100, 25);
            this.btnTakimEkle.Text = "Takım Ekle";
            this.btnTakimEkle.Click += new System.EventHandler(this.btnTakimEkle_Click);

            // btnTakimSil
            this.btnTakimSil.Location = new System.Drawing.Point(500, 90);
            this.btnTakimSil.Name = "btnTakimSil";
            this.btnTakimSil.Size = new System.Drawing.Size(100, 25);
            this.btnTakimSil.Text = "Takım Sil";
            this.btnTakimSil.Click += new System.EventHandler(this.btnTakimSil_Click);

            // btnOyuncuEkle
            this.btnOyuncuEkle.Location = new System.Drawing.Point(500, 130);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(100, 25);
            this.btnOyuncuEkle.Text = "Oyuncu Ekle";
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);

            // btnOyuncuCikar
            this.btnOyuncuCikar.Location = new System.Drawing.Point(500, 170);
            this.btnOyuncuCikar.Name = "btnOyuncuCikar";
            this.btnOyuncuCikar.Size = new System.Drawing.Size(100, 25);
            this.btnOyuncuCikar.Text = "Oyuncu Çıkar";
            this.btnOyuncuCikar.Click += new System.EventHandler(this.btnOyuncuCikar_Click);

            // TakımlarFormu
            this.ClientSize = new System.Drawing.Size(700, 400);
            this.Controls.Add(this.lblBaslik);
            this.Controls.Add(this.dataGridViewTakimlar);
            this.Controls.Add(this.listBoxBosOyuncular);
            this.Controls.Add(this.btnTakimEkle);
            this.Controls.Add(this.btnTakimSil);
            this.Controls.Add(this.btnOyuncuEkle);
            this.Controls.Add(this.btnOyuncuCikar);
            this.Text = "Takımlar Formu";
            this.Load += new System.EventHandler(this.TakımlarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakimlar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}