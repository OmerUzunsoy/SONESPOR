namespace EsportsApp
{
    partial class OyuncuCikarFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewTakimlar;
        private System.Windows.Forms.ListBox listBoxOyuncular;
        private System.Windows.Forms.Button btnCikar;

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
            this.dataGridViewTakimlar = new System.Windows.Forms.DataGridView();
            this.listBoxOyuncular = new System.Windows.Forms.ListBox();
            this.btnCikar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakimlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTakimlar
            // 
            this.dataGridViewTakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTakimlar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTakimlar.Name = "dataGridViewTakimlar";
            this.dataGridViewTakimlar.Size = new System.Drawing.Size(360, 150);
            this.dataGridViewTakimlar.TabIndex = 0;
            this.dataGridViewTakimlar.SelectionChanged += new System.EventHandler(this.dataGridViewTakimlar_SelectionChanged);
            // 
            // listBoxOyuncular
            // 
            this.listBoxOyuncular.FormattingEnabled = true;
            this.listBoxOyuncular.Location = new System.Drawing.Point(12, 180);
            this.listBoxOyuncular.Name = "listBoxOyuncular";
            this.listBoxOyuncular.Size = new System.Drawing.Size(360, 95);
            this.listBoxOyuncular.TabIndex = 1;
            // 
            // btnCikar
            // 
            this.btnCikar.Location = new System.Drawing.Point(150, 290);
            this.btnCikar.Name = "btnCikar";
            this.btnCikar.Size = new System.Drawing.Size(75, 25);
            this.btnCikar.TabIndex = 2;
            this.btnCikar.Text = "Çıkar";
            this.btnCikar.UseVisualStyleBackColor = true;
            this.btnCikar.Click += new System.EventHandler(this.btnCikar_Click);
            // 
            // OyuncuCikarFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 331);
            this.Controls.Add(this.btnCikar);
            this.Controls.Add(this.listBoxOyuncular);
            this.Controls.Add(this.dataGridViewTakimlar);
            this.Name = "OyuncuCikarFormu";
            this.Text = "Oyuncu Çıkarma";
            this.Load += new System.EventHandler(this.OyuncuCikarFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakimlar)).EndInit();
            this.ResumeLayout(false);

        }
    }
}