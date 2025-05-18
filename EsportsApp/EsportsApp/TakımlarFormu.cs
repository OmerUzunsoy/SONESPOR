using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class TakımlarFormu : Form
    {
        public TakımlarFormu()
        {
            InitializeComponent();
        }

        private void TakımlarFormu_Load(object sender, EventArgs e)
        {
            // Form yüklendiğinde verileri yükle
            TakimlariYukle();
            BosOyunculariYukle();
        }

        // Takımlar tablosunu yükler
        private void TakimlariYukle()
        {
            string query = "SELECT takim_id, takim_adi AS \"Takım Adı\", uyeler AS \"Üyeler\", kaptan AS \"Kaptan\" FROM Takimlar ORDER BY takim_id";
            var dt = DatabaseHelper.ExecuteQuery(query);
            dataGridViewTakimlar.DataSource = dt;

            if (dataGridViewTakimlar.Columns.Contains("takim_id"))
                dataGridViewTakimlar.Columns["takim_id"].Visible = false; // ID sütununu gizle
        }

        // Boş oyuncuları yükler
        private void BosOyunculariYukle()
        {
            string query = @"
                SELECT kullanici_adi 
                FROM Kullanici 
                WHERE kullanici_adi NOT IN (
                    SELECT unnest(string_to_array(uyeler, ', ')) FROM Takimlar WHERE uyeler IS NOT NULL
                )
                ORDER BY kullanici_adi";
            var dt = DatabaseHelper.ExecuteQuery(query);
            listBoxBosOyuncular.DataSource = dt;
            listBoxBosOyuncular.DisplayMember = "kullanici_adi";
        }

        // "Takım Ekle" butonu işlevi
        private void btnTakimEkle_Click(object sender, EventArgs e)
        {
            using (var takimEkleFormu = new TakimEkleFormu())
            {
                if (takimEkleFormu.ShowDialog() == DialogResult.OK)
                {
                    TakimlariYukle();
                    BosOyunculariYukle();
                }
            }
        }

        // Seçilen takımı siler
        private void btnTakimSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewTakimlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir takım seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int takimId = Convert.ToInt32(dataGridViewTakimlar.SelectedRows[0].Cells["takim_id"].Value);
            string query = "DELETE FROM Takimlar WHERE takim_id = @takim_id";
            DatabaseHelper.ExecuteNonQuery(query, new NpgsqlParameter("@takim_id", takimId));

            MessageBox.Show("Takım başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

            TakimlariYukle();
            BosOyunculariYukle();
        }

        // "Oyuncu Ekle" butonu işlevi
        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            if (listBoxBosOyuncular.SelectedItem == null)
            {
                MessageBox.Show("Lütfen boşta olan bir oyuncu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string oyuncu = ((DataRowView)listBoxBosOyuncular.SelectedItem)["kullanici_adi"].ToString();

            using (var takimSecimFormu = new TakimSecimFormu())
            {
                if (takimSecimFormu.ShowDialog() == DialogResult.OK)
                {
                    int takimId = takimSecimFormu.SecilenTakimId;

                    string query = @"
                        UPDATE Takimlar
                        SET uyeler = CASE
                            WHEN uyeler IS NULL OR uyeler = '' THEN @oyuncu
                            ELSE uyeler || ', ' || @oyuncu
                        END
                        WHERE takim_id = @takim_id";
                    DatabaseHelper.ExecuteNonQuery(query,
                        new NpgsqlParameter("@oyuncu", oyuncu),
                        new NpgsqlParameter("@takim_id", takimId));

                    MessageBox.Show($"Oyuncu başarıyla eklendi: {oyuncu}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TakimlariYukle();
                    BosOyunculariYukle();
                }
            }
        }

        // "Oyuncu Çıkar" butonu işlevi
        private void btnOyuncuCikar_Click(object sender, EventArgs e)
        {
            using (var oyuncuCikarFormu = new OyuncuCikarFormu())
            {
                if (oyuncuCikarFormu.ShowDialog() == DialogResult.OK)
                {
                    int takimId = oyuncuCikarFormu.SecilenTakimId;
                    string oyuncu = oyuncuCikarFormu.SecilenOyuncu;

                    string query = @"
                        UPDATE Takimlar
                        SET uyeler = array_to_string(array_remove(string_to_array(uyeler, ', '), @oyuncu), ', ')
                        WHERE takim_id = @takim_id";
                    DatabaseHelper.ExecuteNonQuery(query,
                        new NpgsqlParameter("@oyuncu", oyuncu),
                        new NpgsqlParameter("@takim_id", takimId));

                    MessageBox.Show($"Oyuncu başarıyla çıkarıldı: {oyuncu}", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    TakimlariYukle();
                    BosOyunculariYukle();
                }
            }
        }
    }
}