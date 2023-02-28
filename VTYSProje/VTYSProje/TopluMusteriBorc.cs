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
    public partial class TopluMusteriBorc : Form
    {
        public TopluMusteriBorc()
        {
            InitializeComponent();
        }

        private void TopluMusteriBorc_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet4.tMusteris' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tMusterisTableAdapter.Fill(this.vTYSProjeDataSet4.tMusteris);

        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            RaporlamaSecim raporlamaSecim = new RaporlamaSecim();
            raporlamaSecim.Show();
        }
    }
}
