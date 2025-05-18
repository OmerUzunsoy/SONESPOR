using System;
using System.Data;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class OyuncularFormu : Form
    {
        public OyuncularFormu()
        {
            InitializeComponent();
        }

        private void OyuncularFormu_Load(object sender, EventArgs e)
        {
            OyunculariYukle();
        }

        private void OyunculariYukle()
        {
            string query = "SELECT kullanici_id AS \"ID\", kullanici_adi AS \"Kullanıcı Adı\", email AS \"E-posta\", favori_oyunlar AS \"Favori Oyunlar\" FROM Kullanici ORDER BY kullanici_id";
            var dt = DatabaseHelper.ExecuteQuery(query);
            dataGridViewOyuncular.DataSource = dt;

            if (dataGridViewOyuncular.Columns.Contains("ID"))
                dataGridViewOyuncular.Columns["ID"].Visible = false; // ID sütununu gizle
        }

        // Oyuncu ekleme işlemi
        private void btnOyuncuEkle_Click(object sender, EventArgs e)
        {
            using (var oyuncuEkleDuzenleFormu = new OyuncuEkleDuzenleFormu())
            {
                oyuncuEkleDuzenleFormu.StartPosition = FormStartPosition.CenterParent; // Ortada açılması için
                if (oyuncuEkleDuzenleFormu.ShowDialog() == DialogResult.OK)
                {
                    OyunculariYukle(); // Listeyi güncelle
                }
            }
        }

        // Oyuncu düzenleme işlemi
        private void btnOyuncuDuzenle_Click(object sender, EventArgs e)
        {
            if (dataGridViewOyuncular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen düzenlemek için bir oyuncu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int oyuncuId = Convert.ToInt32(dataGridViewOyuncular.SelectedRows[0].Cells["ID"].Value);
            string kullaniciAdi = dataGridViewOyuncular.SelectedRows[0].Cells["Kullanıcı Adı"].Value.ToString();
            string email = dataGridViewOyuncular.SelectedRows[0].Cells["E-posta"].Value.ToString();
            string favoriOyunlar = dataGridViewOyuncular.SelectedRows[0].Cells["Favori Oyunlar"].Value.ToString();

            using (var oyuncuEkleDuzenleFormu = new OyuncuEkleDuzenleFormu(oyuncuId, kullaniciAdi, email, favoriOyunlar))
            {
                oyuncuEkleDuzenleFormu.StartPosition = FormStartPosition.CenterParent; // Ortada açılması için
                if (oyuncuEkleDuzenleFormu.ShowDialog() == DialogResult.OK)
                {
                    OyunculariYukle(); // Listeyi güncelle
                }
            }
        }

        // Oyuncu silme işlemi
        private void btnOyuncuSil_Click(object sender, EventArgs e)
        {
            if (dataGridViewOyuncular.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen silmek için bir oyuncu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            int oyuncuId = Convert.ToInt32(dataGridViewOyuncular.SelectedRows[0].Cells["ID"].Value);
            string query = "DELETE FROM Kullanici WHERE kullanici_id = @kullanici_id";
            DatabaseHelper.ExecuteNonQuery(query, new NpgsqlParameter("@kullanici_id", oyuncuId));

            MessageBox.Show("Oyuncu başarıyla silindi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
            OyunculariYukle(); // Listeyi güncelle
        }
    }
}