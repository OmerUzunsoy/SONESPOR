namespace EsportsApp
{
    partial class OdullerFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvOduller;
        private System.Windows.Forms.Button btnDuzenle;

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
            this.dgvOduller = new System.Windows.Forms.DataGridView();
            this.btnDuzenle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduller)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvOduller
            // 
            this.dgvOduller.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOduller.Location = new System.Drawing.Point(12, 12);
            this.dgvOduller.Name = "dgvOduller";
            this.dgvOduller.Size = new System.Drawing.Size(760, 400);
            this.dgvOduller.TabIndex = 0;

            // 
            // btnDuzenle
            // 
            this.btnDuzenle.Location = new System.Drawing.Point(12, 430);
            this.btnDuzenle.Name = "btnDuzenle";
            this.btnDuzenle.Size = new System.Drawing.Size(100, 30);
            this.btnDuzenle.TabIndex = 1;
            this.btnDuzenle.Text = "Düzenle";
            this.btnDuzenle.UseVisualStyleBackColor = true;
            this.btnDuzenle.Click += new System.EventHandler(this.btnDuzenle_Click);

            // 
            // OdullerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvOduller);
            this.Controls.Add(this.btnDuzenle);
            this.Name = "OdullerFormu";
            this.Text = "Ödüller";
            ((System.ComponentModel.ISupportInitialize)(this.dgvOduller)).EndInit();
            this.ResumeLayout(false);
        }
    }
}