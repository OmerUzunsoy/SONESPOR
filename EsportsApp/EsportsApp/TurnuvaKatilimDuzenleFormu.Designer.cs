namespace EsportsApp
{
    partial class TurnuvaKatilimEkleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblKullanici;
        private System.Windows.Forms.ComboBox cmbKullanici;
        private System.Windows.Forms.Label lblTurnuva;
        private System.Windows.Forms.ComboBox cmbTurnuva;
        private System.Windows.Forms.Label lblTakim;
        private System.Windows.Forms.ComboBox cmbTakim;
        private System.Windows.Forms.CheckBox chkBireysel;
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
            this.lblKullanici = new System.Windows.Forms.Label();
            this.cmbKullanici = new System.Windows.Forms.ComboBox();
            this.lblTurnuva = new System.Windows.Forms.Label();
            this.cmbTurnuva = new System.Windows.Forms.ComboBox();
            this.lblTakim = new System.Windows.Forms.Label();
            this.cmbTakim = new System.Windows.Forms.ComboBox();
            this.chkBireysel = new System.Windows.Forms.CheckBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();

            // 
            // lblKullanici
            // 
            this.lblKullanici.AutoSize = true;
            this.lblKullanici.Location = new System.Drawing.Point(30, 20);
            this.lblKullanici.Name = "lblKullanici";
            this.lblKullanici.Size = new System.Drawing.Size(80, 20);
            this.lblKullanici.Text = "Kullanıcı:";
            // 
            // cmbKullanici
            // 
            this.cmbKullanici.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbKullanici.Location = new System.Drawing.Point(150, 20);
            this.cmbKullanici.Name = "cmbKullanici";
            this.cmbKullanici.Size = new System.Drawing.Size(200, 28);
            // 
            // lblTurnuva
            // 
            this.lblTurnuva.AutoSize = true;
            this.lblTurnuva.Location = new System.Drawing.Point(30, 70);
            this.lblTurnuva.Name = "lblTurnuva";
            this.lblTurnuva.Size = new System.Drawing.Size(80, 20);
            this.lblTurnuva.Text = "Turnuva:";
            // 
            // cmbTurnuva
            // 
            this.cmbTurnuva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTurnuva.Location = new System.Drawing.Point(150, 70);
            this.cmbTurnuva.Name = "cmbTurnuva";
            this.cmbTurnuva.Size = new System.Drawing.Size(200, 28);
            // 
            // lblTakim
            // 
            this.lblTakim.AutoSize = true;
            this.lblTakim.Location = new System.Drawing.Point(30, 120);
            this.lblTakim.Name = "lblTakim";
            this.lblTakim.Size = new System.Drawing.Size(60, 20);
            this.lblTakim.Text = "Takım:";
            // 
            // cmbTakim
            // 
            this.cmbTakim.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTakim.Location = new System.Drawing.Point(150, 120);
            this.cmbTakim.Name = "cmbTakim";
            this.cmbTakim.Size = new System.Drawing.Size(200, 28);
            // 
            // chkBireysel
            // 
            this.chkBireysel.AutoSize = true;
            this.chkBireysel.Location = new System.Drawing.Point(150, 170);
            this.chkBireysel.Name = "chkBireysel";
            this.chkBireysel.Size = new System.Drawing.Size(100, 24);
            this.chkBireysel.Text = "Bireysel Katılım";
            // 
            // btnKaydet
            // 
            this.btnKaydet.Location = new System.Drawing.Point(150, 220);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 30);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);
            // 
            // btnIptal
            // 
            this.btnIptal.Location = new System.Drawing.Point(260, 220);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 30);
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);
            // 
            // TurnuvaKatilimEkleFormu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 280);
            this.Controls.Add(this.lblKullanici);
            this.Controls.Add(this.cmbKullanici);
            this.Controls.Add(this.lblTurnuva);
            this.Controls.Add(this.cmbTurnuva);
            this.Controls.Add(this.lblTakim);
            this.Controls.Add(this.cmbTakim);
            this.Controls.Add(this.chkBireysel);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Name = "TurnuvaKatilimEkleFormu";
            this.Text = "Turnuva Katılım Ekle";
        }
    }
}