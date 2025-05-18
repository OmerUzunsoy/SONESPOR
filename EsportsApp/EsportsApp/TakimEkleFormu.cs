using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using Npgsql;

namespace EsportsApp
{
    public partial class TakimEkleFormu : Form
    {
        private BindingList<string> bosOyuncularListesi;
        private BindingList<string> secilenOyuncularListesi;

        public TakimEkleFormu()
        {
            InitializeComponent();
        }

        private void TakimEkleFormu_Load(object sender, EventArgs e)
        {
            BosOyunculariYukle();
        }

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

            bosOyuncularListesi = new BindingList<string>(dt.AsEnumerable().Select(row => row.Field<string>("kullanici_adi")).ToList());
            secilenOyuncularListesi = new BindingList<string>();

            listBoxBosOyuncular.DataSource = bosOyuncularListesi;
            listBoxSecilenOyuncular.DataSource = secilenOyuncularListesi;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            if (listBoxBosOyuncular.SelectedItem != null)
            {
                string selectedPlayer = listBoxBosOyuncular.SelectedItem.ToString();

                bosOyuncularListesi.Remove(selectedPlayer);
                secilenOyuncularListesi.Add(selectedPlayer);
            }
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (listBoxSecilenOyuncular.SelectedItem != null)
            {
                string selectedPlayer = listBoxSecilenOyuncular.SelectedItem.ToString();

                secilenOyuncularListesi.Remove(selectedPlayer);
                bosOyuncularListesi.Add(selectedPlayer);
            }
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            string takimAdi = txtTakimAdi.Text.Trim();
            string kaptan = txtKaptan.Text.Trim();
            var uyeler = string.Join(", ", secilenOyuncularListesi);

            if (string.IsNullOrEmpty(takimAdi) || string.IsNullOrEmpty(kaptan))
            {
                MessageBox.Show("Takım adı ve kaptan bilgisi boş olamaz.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string query = "INSERT INTO Takimlar (takim_adi, uyeler, kaptan) VALUES (@takim_adi, @uyeler, @kaptan)";
                DatabaseHelper.ExecuteNonQuery(query,
                    new NpgsqlParameter("@takim_adi", takimAdi),
                    new NpgsqlParameter("@uyeler", string.IsNullOrEmpty(uyeler) ? kaptan : kaptan + ", " + uyeler),
                    new NpgsqlParameter("@kaptan", kaptan));

                MessageBox.Show("Takım başarıyla eklendi.", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Veritabanı hatası: {ex.Message}", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}