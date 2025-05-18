using System;
using System.Data;
using System.Windows.Forms;

namespace EsportsApp
{
    public partial class TakimSecimFormu : Form
    {
        public int SecilenTakimId { get; private set; }

        public TakimSecimFormu()
        {
            InitializeComponent();
            TakimlariYukle();
        }

        // Takımları listele
        private void TakimlariYukle()
        {
            string query = "SELECT takim_id, takim_adi AS \"Takım Adı\" FROM Takimlar ORDER BY takim_id";
            var dt = DatabaseHelper.ExecuteQuery(query);
            dataGridViewTakimlar.DataSource = dt;

            if (dataGridViewTakimlar.Columns.Contains("takim_id"))
                dataGridViewTakimlar.Columns["takim_id"].Visible = false; // ID sütununu gizle
        }

        private void btnSec_Click(object sender, EventArgs e)
        {
            if (dataGridViewTakimlar.SelectedRows.Count == 0)
            {
                MessageBox.Show("Lütfen bir takım seçin.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SecilenTakimId = Convert.ToInt32(dataGridViewTakimlar.SelectedRows[0].Cells["takim_id"].Value);
            DialogResult = DialogResult.OK;
            Close();
        }

        private void TakimSecimFormu_Load(object sender, EventArgs e)
        {

        }
    }
}