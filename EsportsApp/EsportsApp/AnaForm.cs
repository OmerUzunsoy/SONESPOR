using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace EsportsApp
{
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        // Form yüklenirken tablo verilerini SQL'den çek ve görsel düzenlemeleri yap
        private void AnaForm_Load(object sender, EventArgs e)
        {
            try
            {
                LoadAllTables(); // Tabloları yükle
                CustomizeFormAppearance(); // Görsel düzenlemeler
                ConfigureDataGrids(); // DataGridView'ları yapılandır
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Başlangıç sırasında bir hata oluştu: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Görsel düzenlemeler
        private void CustomizeFormAppearance()
        {
            // Arka plan rengi
            this.BackColor = Color.FromArgb(240, 240, 240);

            // Başlık düzenlemeleri
            titleLabel.Font = new Font("Arial", 36, FontStyle.Bold);
            titleLabel.ForeColor = Color.White;
            titleLabel.BackColor = Color.FromArgb(0, 102, 204);
            titleLabel.TextAlign = ContentAlignment.MiddleCenter;
            titleLabel.Dock = DockStyle.Top;
            titleLabel.Height = 80;

            // Tablo arka planları
            takımlardataGridView1.BackgroundColor = Color.White;
            turnuvlardataGridView2.BackgroundColor = Color.White;
            oyunculardataGridView3.BackgroundColor = Color.White;
        }

        // DataGridView yapılandırması
        private void ConfigureDataGrids()
        {
            // Tüm tabloları düzenlemeye kapat
            takımlardataGridView1.ReadOnly = true;
            turnuvlardataGridView2.ReadOnly = true;
            oyunculardataGridView3.ReadOnly = true;

            // Satır seçimini etkinleştir, hücre seçimini devre dışı bırak
            takımlardataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            turnuvlardataGridView2.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            oyunculardataGridView3.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Kullanıcıların sütun boyutlarını değiştirmesini devre dışı bırak
            takımlardataGridView1.AllowUserToResizeColumns = false;
            turnuvlardataGridView2.AllowUserToResizeColumns = false;
            oyunculardataGridView3.AllowUserToResizeColumns = false;

            // ALTTAKİ BOŞ SATIRI KALDIRMAK İÇİN:
            takımlardataGridView1.AllowUserToAddRows = false;
            turnuvlardataGridView2.AllowUserToAddRows = false;
            oyunculardataGridView3.AllowUserToAddRows = false;
        }

        // SQL'den tüm verileri çek ve DataGridView'lara ata
        private void LoadAllTables()
        {
            try
            {
                // Takımlar tablosu
                string takimlarQuery = "SELECT takim_adi AS \"Takım Adı\", uyeler AS \"Üyeler\", kaptan AS \"Kaptan\" FROM Takimlar;";
                takımlardataGridView1.DataSource = DatabaseHelper.ExecuteQuery(takimlarQuery);

                // Turnuvalar tablosu
                string turnuvalarQuery = "SELECT turnuva_adi AS \"Turnuva Adı\", turu AS \"Türü\", tarih AS \"Tarih\", aciklama AS \"Açıklama\" FROM Turnuvalar;";
                turnuvlardataGridView2.DataSource = DatabaseHelper.ExecuteQuery(turnuvalarQuery);

                // Oyuncular tablosu
                string oyuncularQuery = "SELECT kullanici_adi AS \"Oyuncu Adı\", favori_oyunlar AS \"Favori Oyunlar\" FROM Kullanici;";
                oyunculardataGridView3.DataSource = DatabaseHelper.ExecuteQuery(oyuncularQuery);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veri yüklenirken bir hata oluştu: {ex.Message}", "Veri Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // **Arama Butonu** (Tüm tablolar üzerinde arama yapar)
        private void button1_Click(object sender, EventArgs e)
        {
            string searchText = aratxt.Text.Trim();
            string selectedFilter = comboBox1.SelectedItem?.ToString();

            if (string.IsNullOrEmpty(selectedFilter))
            {
                MessageBox.Show("Lütfen bir filtre seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                if (selectedFilter == "Takımlar")
                {
                    string query = string.IsNullOrEmpty(searchText)
                        ? "SELECT takim_adi AS \"Takım Adı\", uyeler AS \"Üyeler\", kaptan AS \"Kaptan\" FROM Takimlar"
                        : $@"
                            SELECT takim_adi AS ""Takım Adı"", uyeler AS ""Üyeler"", kaptan AS ""Kaptan"" 
                            FROM Takimlar
                            WHERE takim_adi ILIKE '%{searchText}%'
                               OR uyeler ILIKE '%{searchText}%'
                               OR kaptan ILIKE '%{searchText}%'";
                    takımlardataGridView1.DataSource = DatabaseHelper.ExecuteQuery(query);
                }
                else if (selectedFilter == "Turnuvalar")
                {
                    string query = string.IsNullOrEmpty(searchText)
                        ? "SELECT turnuva_adi AS \"Turnuva Adı\", turu AS \"Türü\", tarih AS \"Tarih\", aciklama AS \"Açıklama\" FROM Turnuvalar"
                        : $@"
                            SELECT turnuva_adi AS ""Turnuva Adı"", turu AS ""Türü"", tarih AS ""Tarih"", aciklama AS ""Açıklama"" 
                            FROM Turnuvalar
                            WHERE turnuva_adi ILIKE '%{searchText}%'
                               OR turu ILIKE '%{searchText}%'
                               OR CAST(tarih AS TEXT) ILIKE '%{searchText}%'
                               OR aciklama ILIKE '%{searchText}%'";
                    turnuvlardataGridView2.DataSource = DatabaseHelper.ExecuteQuery(query);
                }
                else if (selectedFilter == "Oyuncular")
                {
                    string query = string.IsNullOrEmpty(searchText)
                        ? "SELECT kullanici_adi AS \"Oyuncu Adı\", favori_oyunlar AS \"Favori Oyunlar\" FROM Kullanici"
                        : $@"
                            SELECT kullanici_adi AS ""Oyuncu Adı"", favori_oyunlar AS ""Favori Oyunlar"" 
                            FROM Kullanici
                            WHERE kullanici_adi ILIKE '%{searchText}%'
                               OR favori_oyunlar ILIKE '%{searchText}%'";
                    oyunculardataGridView3.DataSource = DatabaseHelper.ExecuteQuery(query);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Arama sırasında bir hata oluştu: {ex.Message}", "Arama Hatası", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // **Filtreleme (Sadece seçilen tabloyu gösterir)**
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedFilter = comboBox1.SelectedItem?.ToString();

            takımlardataGridView1.Visible = selectedFilter == "Takımlar";
            turnuvlardataGridView2.Visible = selectedFilter == "Turnuvalar";
            oyunculardataGridView3.Visible = selectedFilter == "Oyuncular";
        }

        // Tüm verileri tekrar yükle
        private void btnTumunuGoster_Click(object sender, EventArgs e)
        {
            LoadAllTables();
        }

        // Takımlar formunu aç
        private void button2_Click(object sender, EventArgs e)
        {
            TakımlarFormu takımlarFormu = new TakımlarFormu();
            takımlarFormu.Show();
        }

        // Turnuvalar formunu aç
        private void button2_Click_1(object sender, EventArgs e)
        {
            TurnuvalarFormu turnuvalarFormu = new TurnuvalarFormu();
            turnuvalarFormu.Show();
        }

        // Oyuncular formunu aç
        private void button4_Click(object sender, EventArgs e)
        {
            OyuncularFormu oyuncularFormu = new OyuncularFormu();
            oyuncularFormu.Show();
        }

        // AnaForm'un kapanışında uygulamanın tamamen kapanması için:
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            base.OnFormClosing(e);
            Application.Exit();
        }

        private void btnMaclar_Click(object sender, EventArgs e)
        {
            MaclarFormu maclarFormu = new MaclarFormu();
            maclarFormu.ShowDialog();
        }

        private void btnTurnuvaKatilimKayitlari_Click(object sender, EventArgs e)
        {
            // Turnuva Katılım Kayıtları Formunu aç
            TurnuvaKatilimKayitlariFormu form = new TurnuvaKatilimKayitlariFormu();
            form.ShowDialog(); // Formu modal olarak gösterir
        }

        private void btnIstatistikler_Click(object sender, EventArgs e)
        {
            IstatistiklerFormu istatistiklerFormu = new IstatistiklerFormu();
            istatistiklerFormu.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OdullerFormu odullerFormu = new OdullerFormu();
            odullerFormu.ShowDialog();
        }

        private void cikisayapbutton_Click(object sender, EventArgs e)
        {
            // Giriş ekranını aç
            GirisForm girisForm = new GirisForm();
            girisForm.Show();

            // Mevcut AnaForm'u gizle
            this.Hide();
        }
    }
}