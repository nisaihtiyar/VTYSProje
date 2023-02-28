using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
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

        Entity.Context dbcontext = new Entity.Context();

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            RaporlamaSecim raporlamaSecim= new RaporlamaSecim();
            raporlamaSecim.Show();
        }
        private void SatisSiralama_Load(object sender, EventArgs e)
        {
            var urunsorgu = dbcontext.tSatiss.GroupBy(y => y.urunAdi).Select(x => new
            {

                Urun = x.Key,
                Miktar = x.Sum(g => g.satisMiktar)
            }).OrderByDescending(x => x.Miktar);

            dataGridView1.DataSource = urunsorgu.ToList();

            dataGridView1.Columns[0].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].HeaderText = "Satılan Miktar";

        }
    }
}
