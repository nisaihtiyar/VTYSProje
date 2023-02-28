using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSProje
{
    public partial class SatisSiralama : Form
    {
        public SatisSiralama()
        {
            InitializeComponent();
        }

        private void SatisSiralama_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet3.tSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tSatisTableAdapter.Fill(this.vTYSProjeDataSet3.tSatis);

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            RaporlamaSecim raporlamaSecim= new RaporlamaSecim();
            raporlamaSecim.Show();
        }
    }
}
