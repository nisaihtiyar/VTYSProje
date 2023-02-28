using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace VTYSProje
{
    public partial class SatisTrendi : Form
    {
       
        string tarih1;
        string tarih2;
        public SatisTrendi()
        {
            InitializeComponent();
        }
        Entity.Context dbcontext = new Entity.Context();

        private void rjButton5_Click(object sender, EventArgs e)
        {
         
            tarih1=dateTimePicker1.Value.ToShortDateString();
            tarih2 = dateTimePicker2.Value.ToShortDateString();
            

            // iki tarih arasinda satilan urun miktarinin siralamasi
            var urunsorgu1 = dbcontext.tSatiss.Where(x => x.satisTarih == tarih1 || x.satisTarih == tarih2).GroupBy(y => y.urunAdi).Select(x => new
            {

                Urun = x.Key,
                Miktar = x.Sum(g => g.satisMiktar)
            });
 

          dataGridView1.DataSource = urunsorgu1.ToList();
          
          dataGridView1.Columns[0].HeaderText = "Ürün Adı";
          dataGridView1.Columns[1].HeaderText = "Satılan Miktar";



            //Raporun grafikte gosterilmesi

            for (int i = 0;i< dataGridView1.Rows.Count; i++) 
            {
                Series sutunlar = this.chart1.Series.Add(dataGridView1.Rows[i].Cells[0].Value.ToString());
                sutunlar.Points.Add(Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value));
            }
 
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            RaporlamaSecim rapsec1 = new RaporlamaSecim();  
            rapsec1.Show();
        }
    }
}
