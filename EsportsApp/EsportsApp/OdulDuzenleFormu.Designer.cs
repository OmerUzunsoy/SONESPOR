namespace EsportsApp
{
    partial class OdulDuzenleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TextBox txtOdulMiktari;
        private System.Windows.Forms.TextBox txtOdulTuru;
        private System.Windows.Forms.Label lblOdulMiktari;
        private System.Windows.Forms.Label lblOdulTuru;
        private System.Windows.Forms.Button btnKaydet;
        private System.Windows.Forms.Button btnIptal;

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
            this.txtOdulMiktari = new System.Windows.Forms.TextBox();
            this.txtOdulTuru = new System.Windows.Forms.TextBox();
            this.lblOdulMiktari = new System.Windows.Forms.Label();
            this.lblOdulTuru = new System.Windows.Forms.Label();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();

            // 
            // txtOdulMiktari
            // 
            this.txtOdulMiktari.Location = new System.Drawing.Point(150, 20);
            this.txtOdulMiktari.Name = "txtOdulMiktari";
            this.txtOdulMiktari.Size = new System.Drawing.Size(200, 28);
            this.txtOdulMiktari.TabIndex = 0;

            // 
            // txtOdulTuru
            // 
            this.txtOdulTuru.Location = new System.Drawing.Point(150, 70);
            this.txtOdulTuru.Name = "txtOdulTuru";
            this.txtOdulTuru.Size = new System.Drawing.Size(200, 28);
            this.txtOdulTuru.TabIndex = 1;

            // 
            // lblOdulMiktari
            // 
            this.lblOdulMiktari.AutoSize = true;
            this.lblOdulMiktari.Location = new System.Drawing.Point(30, 20);
            this.lblOdulMiktari.Name = "lblOdulMiktari";
            this.lblOdulMiktari.Size = new System.Drawing.Size(100, 20);
            this.lblOdulMiktari.Text = "Ödül Miktarı:";

            // 
            // lblOdulTuru
            // 
            this.lblOdulTuru.AutoSize = true;
            this.lblOdulTuru.Location = new System.Drawing.Point(30, 70);
            this.lblOdulTuru.Name = "lblOdulTuru";
            this.lblOdulTuru.Size = new System.Drawing.Size(80, 20);
            this.lblOdulTuru.Text = "Ödül Türü:";

            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 120);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.TabIndex = 2;
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(260, 120);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 30);
            this.btnIptal.TabIndex = 3;
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // 
            // OdulDuzenleFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 180);
            this.Controls.Add(this.txtOdulMiktari);
            this.Controls.Add(this.txtOdulTuru);
            this.Controls.Add(this.lblOdulMiktari);
            this.Controls.Add(this.lblOdulTuru);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Name = "OdulDuzenleFormu";
            this.Text = "Ödül Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}