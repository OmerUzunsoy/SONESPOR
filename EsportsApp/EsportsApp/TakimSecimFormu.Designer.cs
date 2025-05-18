namespace EsportsApp
{
    partial class TakimSecimFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dataGridViewTakimlar;
        private System.Windows.Forms.Button btnSec;

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
            this.btnSec = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakimlar)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridViewTakimlar
            // 
            this.dataGridViewTakimlar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTakimlar.Location = new System.Drawing.Point(12, 12);
            this.dataGridViewTakimlar.Name = "dataGridViewTakimlar";
            this.dataGridViewTakimlar.Size = new System.Drawing.Size(360, 200);
            this.dataGridViewTakimlar.TabIndex = 0;
            // 
            // btnSec
            // 
            this.btnSec.Location = new System.Drawing.Point(150, 230);
            this.btnSec.Name = "btnSec";
            this.btnSec.Size = new System.Drawing.Size(75, 25);
            this.btnSec.TabIndex = 1;
            this.btnSec.Text = "Seç";
            this.btnSec.UseVisualStyleBackColor = true;
            this.btnSec.Click += new System.EventHandler(this.btnSec_Click);
            // 
            // TakimSecimFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 281);
            this.Controls.Add(this.btnSec);
            this.Controls.Add(this.dataGridViewTakimlar);
            this.Name = "TakimSecimFormu";
            this.Text = "Takım Seçimi";
            this.Load += new System.EventHandler(this.TakimSecimFormu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTakimlar)).EndInit();
            this.ResumeLayout(false);

        }
    }
}