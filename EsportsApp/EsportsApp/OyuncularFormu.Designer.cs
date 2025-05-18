namespace EsportsApp
{
    partial class OyuncularFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewOyuncular;
        private System.Windows.Forms.Button btnOyuncuEkle;
        private System.Windows.Forms.Button btnOyuncuDuzenle;
        private System.Windows.Forms.Button btnOyuncuSil;

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
            this.dataGridViewOyuncular = new System.Windows.Forms.DataGridView();
            this.btnOyuncuEkle = new System.Windows.Forms.Button();
            this.btnOyuncuDuzenle = new System.Windows.Forms.Button();
            this.btnOyuncuSil = new System.Windows.Forms.Button();

            // dataGridViewOyuncular
            this.dataGridViewOyuncular.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewOyuncular.Location = new System.Drawing.Point(20, 20);
            this.dataGridViewOyuncular.Name = "dataGridViewOyuncular";
            this.dataGridViewOyuncular.Size = new System.Drawing.Size(600, 300);

            // btnOyuncuEkle
            this.btnOyuncuEkle.Location = new System.Drawing.Point(20, 340);
            this.btnOyuncuEkle.Name = "btnOyuncuEkle";
            this.btnOyuncuEkle.Size = new System.Drawing.Size(100, 30);
            this.btnOyuncuEkle.Text = "Oyuncu Ekle";
            this.btnOyuncuEkle.Click += new System.EventHandler(this.btnOyuncuEkle_Click);

            // btnOyuncuDuzenle
            this.btnOyuncuDuzenle.Location = new System.Drawing.Point(140, 340);
            this.btnOyuncuDuzenle.Name = "btnOyuncuDuzenle";
            this.btnOyuncuDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnOyuncuDuzenle.Text = "Oyuncu Düzenle";
            this.btnOyuncuDuzenle.Click += new System.EventHandler(this.btnOyuncuDuzenle_Click);

            // btnOyuncuSil
            this.btnOyuncuSil.Location = new System.Drawing.Point(260, 340);
            this.btnOyuncuSil.Name = "btnOyuncuSil";
            this.btnOyuncuSil.Size = new System.Drawing.Size(100, 30);
            this.btnOyuncuSil.Text = "Oyuncu Sil";
            this.btnOyuncuSil.Click += new System.EventHandler(this.btnOyuncuSil_Click);

            // OyuncularFormu
            this.ClientSize = new System.Drawing.Size(650, 400);
            this.Controls.Add(this.dataGridViewOyuncular);
            this.Controls.Add(this.btnOyuncuEkle);
            this.Controls.Add(this.btnOyuncuDuzenle);
            this.Controls.Add(this.btnOyuncuSil);
            this.Text = "Oyuncular";
            this.Load += new System.EventHandler(this.OyuncularFormu_Load);
        }
    }
}