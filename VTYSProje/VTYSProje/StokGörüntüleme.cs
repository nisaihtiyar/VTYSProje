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
    public partial class StokGörüntüleme : Form
    {
        public StokGörüntüleme()
        {
            InitializeComponent();
        }

        private void StokGörüntüleme_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet1.tUruns' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tUrunsTableAdapter.Fill(this.vTYSProjeDataSet1.tUruns);

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            StokEkle stok = new StokEkle();
            stok.Show();
        }
    }
}
