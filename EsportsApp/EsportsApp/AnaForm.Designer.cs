namespace EsportsApp
{
    partial class AnaForm
    {
        /// <summary>
        /// Tasarımcı desteği için gerekli değişkenler.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        /// <param name="disposing">Yönetilen kaynakların temizlenip temizlenmediği.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer oluşturulan kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.aratxt = new System.Windows.Forms.TextBox();
            this.arabutton = new System.Windows.Forms.Button();
            this.takımlardataGridView1 = new System.Windows.Forms.DataGridView();
            this.turnuvlardataGridView2 = new System.Windows.Forms.DataGridView();
            this.oyunculardataGridView3 = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.button2_1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.btnTumunuGoster = new System.Windows.Forms.Button();
            this.btnMaclar = new System.Windows.Forms.Button();
            this.btnTurnuvaKatilimKayitlari = new System.Windows.Forms.Button();
            this.btnIstatistikler = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.cikisayapbutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.takımlardataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnuvlardataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunculardataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(102)))), ((int)(((byte)(204)))));
            this.titleLabel.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(0, 0);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1024, 80);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "ESPOR LOBİSİ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Takımlar",
            "Turnuvalar",
            "Oyuncular"});
            this.comboBox1.Location = new System.Drawing.Point(20, 100);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 1;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // aratxt
            // 
            this.aratxt.Location = new System.Drawing.Point(240, 100);
            this.aratxt.Name = "aratxt";
            this.aratxt.Size = new System.Drawing.Size(300, 20);
            this.aratxt.TabIndex = 2;
            // 
            // arabutton
            // 
            this.arabutton.Location = new System.Drawing.Point(560, 95);
            this.arabutton.Name = "arabutton";
            this.arabutton.Size = new System.Drawing.Size(100, 30);
            this.arabutton.TabIndex = 3;
            this.arabutton.Text = "Ara";
            this.arabutton.UseVisualStyleBackColor = true;
            this.arabutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // takımlardataGridView1
            // 
            this.takımlardataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.takımlardataGridView1.Location = new System.Drawing.Point(20, 150);
            this.takımlardataGridView1.Name = "takımlardataGridView1";
            this.takımlardataGridView1.RowHeadersWidth = 51;
            this.takımlardataGridView1.RowTemplate.Height = 24;
            this.takımlardataGridView1.Size = new System.Drawing.Size(613, 300);
            this.takımlardataGridView1.TabIndex = 4;
            // 
            // turnuvlardataGridView2
            // 
            this.turnuvlardataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.turnuvlardataGridView2.Location = new System.Drawing.Point(20, 150);
            this.turnuvlardataGridView2.Name = "turnuvlardataGridView2";
            this.turnuvlardataGridView2.RowHeadersWidth = 51;
            this.turnuvlardataGridView2.RowTemplate.Height = 24;
            this.turnuvlardataGridView2.Size = new System.Drawing.Size(613, 300);
            this.turnuvlardataGridView2.TabIndex = 5;
            this.turnuvlardataGridView2.Visible = false;
            // 
            // oyunculardataGridView3
            // 
            this.oyunculardataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.oyunculardataGridView3.Location = new System.Drawing.Point(20, 150);
            this.oyunculardataGridView3.Name = "oyunculardataGridView3";
            this.oyunculardataGridView3.RowHeadersWidth = 51;
            this.oyunculardataGridView3.RowTemplate.Height = 24;
            this.oyunculardataGridView3.Size = new System.Drawing.Size(613, 300);
            this.oyunculardataGridView3.TabIndex = 6;
            this.oyunculardataGridView3.Visible = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(639, 150);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 40);
            this.button2.TabIndex = 7;
            this.button2.Text = "Takımlar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button2_1
            // 
            this.button2_1.Location = new System.Drawing.Point(822, 150);
            this.button2_1.Name = "button2_1";
            this.button2_1.Size = new System.Drawing.Size(150, 40);
            this.button2_1.TabIndex = 8;
            this.button2_1.Text = "Turnuvalar";
            this.button2_1.UseVisualStyleBackColor = true;
            this.button2_1.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(639, 218);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(150, 40);
            this.button4.TabIndex = 9;
            this.button4.Text = "Oyuncular";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // btnTumunuGoster
            // 
            this.btnTumunuGoster.Location = new System.Drawing.Point(706, 410);
            this.btnTumunuGoster.Name = "btnTumunuGoster";
            this.btnTumunuGoster.Size = new System.Drawing.Size(200, 40);
            this.btnTumunuGoster.TabIndex = 10;
            this.btnTumunuGoster.Text = "Tümünü Göster";
            this.btnTumunuGoster.UseVisualStyleBackColor = true;
            this.btnTumunuGoster.Click += new System.EventHandler(this.btnTumunuGoster_Click);
            // 
            // btnMaclar
            // 
            this.btnMaclar.Location = new System.Drawing.Point(822, 218);
            this.btnMaclar.Name = "btnMaclar";
            this.btnMaclar.Size = new System.Drawing.Size(150, 40);
            this.btnMaclar.TabIndex = 11;
            this.btnMaclar.Text = "Maçlar";
            this.btnMaclar.UseVisualStyleBackColor = true;
            this.btnMaclar.Click += new System.EventHandler(this.btnMaclar_Click);
            // 
            // btnTurnuvaKatilimKayitlari
            // 
            this.btnTurnuvaKatilimKayitlari.Location = new System.Drawing.Point(639, 284);
            this.btnTurnuvaKatilimKayitlari.Name = "btnTurnuvaKatilimKayitlari";
            this.btnTurnuvaKatilimKayitlari.Size = new System.Drawing.Size(149, 40);
            this.btnTurnuvaKatilimKayitlari.TabIndex = 12;
            this.btnTurnuvaKatilimKayitlari.Text = "Turnuva Katılım Kayıtları";
            this.btnTurnuvaKatilimKayitlari.UseVisualStyleBackColor = true;
            this.btnTurnuvaKatilimKayitlari.Click += new System.EventHandler(this.btnTurnuvaKatilimKayitlari_Click);
            // 
            // btnIstatistikler
            // 
            this.btnIstatistikler.Location = new System.Drawing.Point(822, 284);
            this.btnIstatistikler.Name = "btnIstatistikler";
            this.btnIstatistikler.Size = new System.Drawing.Size(149, 40);
            this.btnIstatistikler.TabIndex = 13;
            this.btnIstatistikler.Text = "İstatistikler";
            this.btnIstatistikler.UseVisualStyleBackColor = true;
            this.btnIstatistikler.Click += new System.EventHandler(this.btnIstatistikler_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(729, 347);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 40);
            this.button1.TabIndex = 14;
            this.button1.Text = "Ödüller";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // cikisayapbutton
            // 
            this.cikisayapbutton.Location = new System.Drawing.Point(20, 482);
            this.cikisayapbutton.Name = "cikisayapbutton";
            this.cikisayapbutton.Size = new System.Drawing.Size(134, 46);
            this.cikisayapbutton.TabIndex = 15;
            this.cikisayapbutton.Text = "Çıkış Yap";
            this.cikisayapbutton.UseVisualStyleBackColor = true;
            this.cikisayapbutton.Click += new System.EventHandler(this.cikisayapbutton_Click);
            // 
            // AnaForm
            // 
            this.ClientSize = new System.Drawing.Size(1024, 540);
            this.Controls.Add(this.cikisayapbutton);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnIstatistikler);
            this.Controls.Add(this.btnTurnuvaKatilimKayitlari);
            this.Controls.Add(this.btnMaclar);
            this.Controls.Add(this.btnTumunuGoster);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2_1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.oyunculardataGridView3);
            this.Controls.Add(this.turnuvlardataGridView2);
            this.Controls.Add(this.takımlardataGridView1);
            this.Controls.Add(this.arabutton);
            this.Controls.Add(this.aratxt);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.titleLabel);
            this.Name = "AnaForm";
            this.Text = "EsportsApp - Ana Form";
            this.Load += new System.EventHandler(this.AnaForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.takımlardataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.turnuvlardataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oyunculardataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox aratxt;
        private System.Windows.Forms.Button arabutton;
        private System.Windows.Forms.DataGridView takımlardataGridView1;
        private System.Windows.Forms.DataGridView turnuvlardataGridView2;
        private System.Windows.Forms.DataGridView oyunculardataGridView3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button2_1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button btnTumunuGoster;
        private System.Windows.Forms.Button btnMaclar;
        private System.Windows.Forms.Button btnTurnuvaKatilimKayitlari;
        private System.Windows.Forms.Button btnIstatistikler;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button cikisayapbutton;
    }
}