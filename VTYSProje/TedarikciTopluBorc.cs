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
    public partial class TedarikciTopluBorc : Form
    {
        public TedarikciTopluBorc()
        {
            InitializeComponent();
        }

        private void TedarikciTopluBorc_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet2.ttedarikciOdemes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.ttedarikciOdemesTableAdapter.Fill(this.vTYSProjeDataSet2.ttedarikciOdemes);

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            StokEkle stok1= new StokEkle();
            stok1.Show();
        }
    }
}
