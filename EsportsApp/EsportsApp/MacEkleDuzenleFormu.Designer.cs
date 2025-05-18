namespace EsportsApp
{
    partial class MacEkleDuzenleFormu
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTakim1;
        private System.Windows.Forms.Label lblTakim2;
        private System.Windows.Forms.Label lblTarih;
        private System.Windows.Forms.Label lblTurnuva;
        private System.Windows.Forms.Label lblSaat;
        private System.Windows.Forms.Label lblHarita;
        private System.Windows.Forms.ComboBox cmbTakim1;
        private System.Windows.Forms.ComboBox cmbTakim2;
        private System.Windows.Forms.DateTimePicker dtpTarih;
        private System.Windows.Forms.ComboBox cmbTurnuva;
        private System.Windows.Forms.ComboBox cmbSaat;
        private System.Windows.Forms.ComboBox cmbHarita;
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
            this.lblTakim1 = new System.Windows.Forms.Label();
            this.lblTakim2 = new System.Windows.Forms.Label();
            this.lblTarih = new System.Windows.Forms.Label();
            this.lblTurnuva = new System.Windows.Forms.Label();
            this.lblSaat = new System.Windows.Forms.Label();
            this.lblHarita = new System.Windows.Forms.Label();
            this.cmbTakim1 = new System.Windows.Forms.ComboBox();
            this.cmbTakim2 = new System.Windows.Forms.ComboBox();
            this.dtpTarih = new System.Windows.Forms.DateTimePicker();
            this.cmbTurnuva = new System.Windows.Forms.ComboBox();
            this.cmbSaat = new System.Windows.Forms.ComboBox();
            this.cmbHarita = new System.Windows.Forms.ComboBox();
            this.btnKaydet = new System.Windows.Forms.Button();
            this.btnIptal = new System.Windows.Forms.Button();
            this.SuspendLayout();

            // === Takım 1 Label ===
            this.lblTakim1.AutoSize = true;
            this.lblTakim1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTakim1.Location = new System.Drawing.Point(30, 30);
            this.lblTakim1.Name = "lblTakim1";
            this.lblTakim1.Size = new System.Drawing.Size(80, 19);
            this.lblTakim1.Text = "Takım 1:";

            // === Takım 1 ComboBox ===
            this.cmbTakim1.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbTakim1.Location = new System.Drawing.Point(150, 30);
            this.cmbTakim1.Name = "cmbTakim1";
            this.cmbTakim1.Size = new System.Drawing.Size(200, 26);
            this.cmbTakim1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // === Takım 2 Label ===
            this.lblTakim2.AutoSize = true;
            this.lblTakim2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTakim2.Location = new System.Drawing.Point(30, 70);
            this.lblTakim2.Name = "lblTakim2";
            this.lblTakim2.Size = new System.Drawing.Size(80, 19);
            this.lblTakim2.Text = "Takım 2:";

            // === Takım 2 ComboBox ===
            this.cmbTakim2.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbTakim2.Location = new System.Drawing.Point(150, 70);
            this.cmbTakim2.Name = "cmbTakim2";
            this.cmbTakim2.Size = new System.Drawing.Size(200, 26);
            this.cmbTakim2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // === Tarih Label ===
            this.lblTarih.AutoSize = true;
            this.lblTarih.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTarih.Location = new System.Drawing.Point(30, 110);
            this.lblTarih.Name = "lblTarih";
            this.lblTarih.Size = new System.Drawing.Size(54, 19);
            this.lblTarih.Text = "Tarih:";

            // === Tarih DateTimePicker ===
            this.dtpTarih.Font = new System.Drawing.Font("Arial", 12F);
            this.dtpTarih.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpTarih.Location = new System.Drawing.Point(150, 110);
            this.dtpTarih.Name = "dtpTarih";
            this.dtpTarih.Size = new System.Drawing.Size(200, 26);

            // === Saat Label ===
            this.lblSaat.AutoSize = true;
            this.lblSaat.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblSaat.Location = new System.Drawing.Point(30, 150);
            this.lblSaat.Name = "lblSaat";
            this.lblSaat.Size = new System.Drawing.Size(50, 19);
            this.lblSaat.Text = "Saat:";

            // === Saat ComboBox ===
            this.cmbSaat.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbSaat.Location = new System.Drawing.Point(150, 150);
            this.cmbSaat.Name = "cmbSaat";
            this.cmbSaat.Size = new System.Drawing.Size(200, 26);
            this.cmbSaat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // Saatleri ekle
            for (int i = 1; i <= 23; i++)
            {
                this.cmbSaat.Items.Add($"{i:00}:00");
            }

            // === Harita Label ===
            this.lblHarita.AutoSize = true;
            this.lblHarita.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblHarita.Location = new System.Drawing.Point(30, 190);
            this.lblHarita.Name = "lblHarita";
            this.lblHarita.Size = new System.Drawing.Size(61, 19);
            this.lblHarita.Text = "Harita:";

            // === Harita ComboBox ===
            this.cmbHarita.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbHarita.Location = new System.Drawing.Point(150, 190);
            this.cmbHarita.Name = "cmbHarita";
            this.cmbHarita.Size = new System.Drawing.Size(200, 26);
            this.cmbHarita.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // === Turnuva Label ===
            this.lblTurnuva.AutoSize = true;
            this.lblTurnuva.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.lblTurnuva.Location = new System.Drawing.Point(30, 230);
            this.lblTurnuva.Name = "lblTurnuva";
            this.lblTurnuva.Size = new System.Drawing.Size(80, 19);
            this.lblTurnuva.Text = "Turnuva:";

            // === Turnuva ComboBox ===
            this.cmbTurnuva.Font = new System.Drawing.Font("Arial", 12F);
            this.cmbTurnuva.Location = new System.Drawing.Point(150, 230);
            this.cmbTurnuva.Name = "cmbTurnuva";
            this.cmbTurnuva.Size = new System.Drawing.Size(200, 26);
            this.cmbTurnuva.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;

            // === Kaydet Button ===
            this.btnKaydet.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydet.Location = new System.Drawing.Point(150, 280);
            this.btnKaydet.Name = "btnKaydet";
            this.btnKaydet.Size = new System.Drawing.Size(100, 40);
            this.btnKaydet.Text = "Kaydet";
            this.btnKaydet.UseVisualStyleBackColor = true;
            this.btnKaydet.Click += new System.EventHandler(this.btnKaydet_Click);

            // === İptal Button ===
            this.btnIptal.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold);
            this.btnIptal.Location = new System.Drawing.Point(260, 280);
            this.btnIptal.Name = "btnIptal";
            this.btnIptal.Size = new System.Drawing.Size(100, 40);
            this.btnIptal.Text = "İptal";
            this.btnIptal.UseVisualStyleBackColor = true;
            this.btnIptal.Click += new System.EventHandler(this.btnIptal_Click);

            // === Form Ayarları ===
            this.ClientSize = new System.Drawing.Size(400, 340);
            this.Controls.Add(this.lblTakim1);
            this.Controls.Add(this.cmbTakim1);
            this.Controls.Add(this.lblTakim2);
            this.Controls.Add(this.cmbTakim2);
            this.Controls.Add(this.lblTarih);
            this.Controls.Add(this.dtpTarih);
            this.Controls.Add(this.lblSaat);
            this.Controls.Add(this.cmbSaat);
            this.Controls.Add(this.lblHarita);
            this.Controls.Add(this.cmbHarita);
            this.Controls.Add(this.lblTurnuva);
            this.Controls.Add(this.cmbTurnuva);
            this.Controls.Add(this.btnKaydet);
            this.Controls.Add(this.btnIptal);
            this.Name = "MacEkleDuzenleFormu";
            this.Text = "Maç Ekle/Düzenle";
            this.ResumeLayout(false);
            this.PerformLayout();
        }
    }
}