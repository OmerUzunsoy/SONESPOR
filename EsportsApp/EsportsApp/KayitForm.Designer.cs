namespace EsportsApp
{
    partial class KayitForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtKayitKullaniciAdi = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtKayitEmail = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtKayitSifre = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnKaydiTamamla = new System.Windows.Forms.Button();
            this.checkedListBoxFavoriOyunlar = new System.Windows.Forms.CheckedListBox();
            this.SuspendLayout();
            // 
            // txtKayitKullaniciAdi
            // 
            this.txtKayitKullaniciAdi.Location = new System.Drawing.Point(143, 82);
            this.txtKayitKullaniciAdi.Name = "txtKayitKullaniciAdi";
            this.txtKayitKullaniciAdi.Size = new System.Drawing.Size(122, 20);
            this.txtKayitKullaniciAdi.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(12, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 54);
            this.label1.TabIndex = 1;
            this.label1.Text = "Kullanıcı Adı";
            // 
            // txtKayitEmail
            // 
            this.txtKayitEmail.Location = new System.Drawing.Point(143, 120);
            this.txtKayitEmail.Name = "txtKayitEmail";
            this.txtKayitEmail.Size = new System.Drawing.Size(122, 20);
            this.txtKayitEmail.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(30, 108);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 54);
            this.label2.TabIndex = 1;
            this.label2.Text = "E-posta";
            // 
            // txtKayitSifre
            // 
            this.txtKayitSifre.Location = new System.Drawing.Point(143, 156);
            this.txtKayitSifre.Name = "txtKayitSifre";
            this.txtKayitSifre.PasswordChar = '*';
            this.txtKayitSifre.Size = new System.Drawing.Size(122, 20);
            this.txtKayitSifre.TabIndex = 0;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(39, 144);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 54);
            this.label3.TabIndex = 1;
            this.label3.Text = "Şifre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Unispace", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.Location = new System.Drawing.Point(144, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 39);
            this.label4.TabIndex = 1;
            this.label4.Text = "Kayıt";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(138, 193);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(123, 54);
            this.label5.TabIndex = 1;
            this.label5.Text = "Favori Oyun";
            // 
            // btnKaydiTamamla
            // 
            this.btnKaydiTamamla.Font = new System.Drawing.Font("Sans Serif Collection", 12F, System.Drawing.FontStyle.Bold);
            this.btnKaydiTamamla.Location = new System.Drawing.Point(126, 387);
            this.btnKaydiTamamla.Name = "btnKaydiTamamla";
            this.btnKaydiTamamla.Size = new System.Drawing.Size(161, 47);
            this.btnKaydiTamamla.TabIndex = 3;
            this.btnKaydiTamamla.Text = "Kayıt Ol";
            this.btnKaydiTamamla.UseVisualStyleBackColor = true;
            this.btnKaydiTamamla.Click += new System.EventHandler(this.btnKaydiTamamla_Click);
            // 
            // checkedListBoxFavoriOyunlar
            // 
            this.checkedListBoxFavoriOyunlar.CheckOnClick = true;
            this.checkedListBoxFavoriOyunlar.FormattingEnabled = true;
            this.checkedListBoxFavoriOyunlar.Location = new System.Drawing.Point(109, 233);
            this.checkedListBoxFavoriOyunlar.Name = "checkedListBoxFavoriOyunlar";
            this.checkedListBoxFavoriOyunlar.Size = new System.Drawing.Size(197, 94);
            this.checkedListBoxFavoriOyunlar.TabIndex = 4;
            // 
            // KayitForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(406, 446);
            this.Controls.Add(this.checkedListBoxFavoriOyunlar);
            this.Controls.Add(this.btnKaydiTamamla);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKayitSifre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtKayitEmail);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtKayitKullaniciAdi);
            this.Name = "KayitForm";
            this.Text = "KayitForm";
            this.Load += new System.EventHandler(this.KayitForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtKayitKullaniciAdi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtKayitEmail;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtKayitSifre;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnKaydiTamamla;
        private System.Windows.Forms.CheckedListBox checkedListBoxFavoriOyunlar;
    }
}