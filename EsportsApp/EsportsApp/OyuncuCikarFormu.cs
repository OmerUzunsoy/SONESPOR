using Npgsql;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace EsportsApp
{
    public partial class OyuncuCikarFormu : Form
    {
        public int SecilenTakimId { get; private set; }
        public string SecilenOyuncu { get; private set; }

        public OyuncuCikarFormu()
        {
            InitializeComponent();
            TakimlariYukle();
        }

        private void TakimlariYukle()
        {
            string query = "SELECT takim_id, takim_adi AS \"Takım Adı\" FROM Takimlar ORDER BY takim_id";
            var dt = DatabaseHelper.ExecuteQuery(query);
            dataGridViewTakimlar.DataSource = dt;

            if (dataGridViewTakimlar.Columns.Contains("takim_id"))
                dataGridViewTakimlar.Columns["takim_id"].Visible = false; // ID sütununu gizle
        }

        private void dataGridViewTakimlar_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridViewTakimlar.SelectedRows.Count == 0) return;

            int takimId = Convert.ToInt32(dataGridViewTakimlar.SelectedRows[0].Cells["takim_id"].Value);
            SecilenTakimId = takimId;

            string query = "SELECT unnest(string_to_array(uyeler, ', ')) AS oyuncu FROM Takimlar WHERE takim_id = @takim_id";
            var dt = DatabaseHelper.ExecuteQuery(query, new NpgsqlParameter("@takim_id", takimId));
            listBoxOyuncular.DataSource = dt;
            listBoxOyuncular.DisplayMember = "oyuncu";
        }

        private void btnCikar_Click(object sender, EventArgs e)
        {
            if (listBoxOyuncular.SelectedItem == null)
            {
                MessageBox.Show("Lütfen bir oyuncu seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SecilenOyuncu = ((DataRowView)listBoxOyuncular.SelectedItem)["oyuncu"].ToString();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void OyuncuCikarFormu_Load(object sender, EventArgs e)
        {

        }
    }
}