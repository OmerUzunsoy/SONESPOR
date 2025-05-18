namespace EsportsApp
{
    partial class TurnuvalarFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvTurnuvalar;
        private System.Windows.Forms.Button btnEkle;
        private System.Windows.Forms.Button btnDuzenle;
        private System.Windows.Forms.Button btnSil;

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
            this.dgvTurnuvalar = new System.Windows.Forms.DataGridView();
            this.btnEkle = new System.Windows.Forms.Button();
            this.btnDuzenle = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnuvalar)).BeginInit();
            this.SuspendLayout();

            // dgvTurnuvalar
            this.dgvTurnuvalar.AllowUserToAddRows = false;
            this.dgvTurnuvalar.AllowUserToDeleteRows = false;
            this.dgvTurnuvalar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTurnuvalar.Location = new System.Drawing.Point(12, 12);
            this.dgvTurnuvalar.Name = "dgvTurnuvalar";
            this.dgvTurnuvalar.ReadOnly = true;
            this.dgvTurnuvalar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTurnuvalar.Size = new System.Drawing.Size(500, 250);
            this.dgvTurnuvalar.TabIndex = 0;

            // btnEkle
            this.btnEkle.Location = new System.Drawing.Point(12, 270);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(75, 23);
            this.btnEkle.TabIndex = 1;
            this.btnEkle.Text = "Ekle";
            this.btnEkle.UseVisualStyleBackColor = true;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);

            // btnDuzenle
            this.btnDuzenle.Location = new System.Drawing.Point(93, 270);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(75, 23);
            this.btnDuzenle.TabIndex = 2;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);

            // btnSil
            this.btnSil.Location = new System.Drawing.Point(174, 270);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(75, 23);
            this.btnSil.TabIndex = 3;
            this.btnSil.Text = "Sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);

            // TurnuvalarFormu
            this.ClientSize = new System.Drawing.Size(524, 311);
            this.Controls.Add(this.dgvTurnuvalar);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.btnDuzenle);
            this.Controls.Add(this.btnSil);
            this.Name = "TurnuvalarFormu";
            this.Text = "Turnuvalar";
            this.Load += new System.EventHandler(this.LoadTurnuvalar);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTurnuvalar)).EndInit();
            this.ResumeLayout(false);
        }
    }
}