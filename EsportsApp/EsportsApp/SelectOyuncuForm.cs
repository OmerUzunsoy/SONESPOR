using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EsportsApp
{
    public partial class SelectOyuncuForm : Form
    {
        public string SeciliOyuncu { get; private set; }

        public SelectOyuncuForm()
        {
            InitializeComponent();
        }

        public SelectOyuncuForm(string[] oyuncular)
        {
            InitializeComponent();
            listBox1.Items.AddRange(oyuncular);
            listBox1.SelectedIndex = 0;
            this.AcceptButton = button1;
            button1.Click += (s, e) =>
            {
                if (listBox1.SelectedItem != null)
                {
                    SeciliOyuncu = listBox1.SelectedItem.ToString();
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
            };
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void SelectOyuncuForm_Load(object sender, EventArgs e)
        {

        }
    }
}
