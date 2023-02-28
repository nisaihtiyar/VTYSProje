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
    public partial class MusteriBazlıRapor : Form
    {
        public MusteriBazlıRapor()
        {
            InitializeComponent();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            RaporlamaSecim rapsec1 = new RaporlamaSecim();
            rapsec1.Show();

        }

        private void MusteriBazlıRapor_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet6.tSatis' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tSatisTableAdapter.Fill(this.vTYSProjeDataSet6.tSatis);
            // TODO: Bu kod satırı 'vTYSProjeDataSet5.tBorcs' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tBorcsTableAdapter.Fill(this.vTYSProjeDataSet5.tBorcs);

        }
    }
}
