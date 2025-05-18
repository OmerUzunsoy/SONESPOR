namespace EsportsApp
{
    partial class IstatistiklerFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvIstatistikler;
        private System.Windows.Forms.ComboBox cmbTurnuvalar;
        private System.Windows.Forms.Button btnIstatistikYukle;

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
            this.dgvIstatistikler = new System.Windows.Forms.DataGridView();
            this.cmbTurnuvalar = new System.Windows.Forms.ComboBox();
            this.btnIstatistikYukle = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstatistikler)).BeginInit();
            this.SuspendLayout();

            // 
            // dgvIstatistikler
            // 
            this.dgvIstatistikler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvIstatistikler.Location = new System.Drawing.Point(12, 70);
            this.dgvIstatistikler.Name = "dgvIstatistikler";
            this.dgvIstatistikler.Size = new System.Drawing.Size(760, 400);
            this.dgvIstatistikler.TabIndex = 0;

            // 
            // cmbTurnuvalar
            // 
            this.cmbTurnuvalar.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnuvalar.Location = new System.Drawing.Point(12, 20);
            this.cmbTurnuvalar.Name = "cmbTurnuvalar";
            this.cmbTurnuvalar.Size = new System.Drawing.Size(200, 28);
            this.cmbTurnuvalar.TabIndex = 1;

            // 
            // btnIstatistikYukle
            // 
            this.btnIstatistikYukle.Location = new System.Drawing.Point(230, 20);
            this.btnIstatistikYukle.Name = "btnIstatistikYukle";
            this.btnIstatistikYukle.Size = new System.Drawing.Size(100, 30);
            this.btnIstatistikYukle.TabIndex = 2;
            this.btnIstatistikYukle.Text = "Yükle";
            this.btnIstatistikYukle.UseVisualStyleBackColor = true;
            this.btnIstatistikYukle.Click += new System.EventHandler(this.btnIstatistikYukle_Click);

            // 
            // IstatistiklerFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 561);
            this.Controls.Add(this.dgvIstatistikler);
            this.Controls.Add(this.cmbTurnuvalar);
            this.Controls.Add(this.btnIstatistikYukle);
            this.Name = "IstatistiklerFormu";
            this.Text = "İstatistikler";
            ((System.ComponentModel.ISupportInitialize)(this.dgvIstatistikler)).EndInit();
            this.ResumeLayout(false);
        }
    }
}