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
    public partial class UrunKarZarar : Form
    {
        public UrunKarZarar()
        {
            InitializeComponent();
        }
        Entity.Context dbcontext = new Entity.Context();
        int toplamsatistutar =0 ;
        int toplamalistutar =0 ;
        int karzarar;


        private void rjButton1_Click(object sender, EventArgs e)
        {
            //Satilan urun icin listeleme ve hesaplama
            String urunisim = textBox1.Text.ToString();
            var urunSorguSatis = dbcontext.tSatiss.Select(x => new
            {
                urunadi = x.urunAdi,
                satilantutar = x.satisTutar
            }).Where(x => x.urunadi == urunisim );

            dataGridView2.DataSource = urunSorguSatis.ToList();
            dataGridView2.Columns[0].HeaderText = "Ürün Adı";
            dataGridView2.Columns[1].HeaderText = "Toplam Satış Tutarı";

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                toplamsatistutar += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
            }
            label2.Text = toplamsatistutar.ToString();

            //Alinan urun icin listeleme ve hesaplama
            var urunSorguAlis = dbcontext.tIrsaliyes.Select(x => new
            {
                urunadi = x.urunAdi,
                alinantutar = x.girdiFiyat,
                miktari = x.miktar
            }).Where(x => x.urunadi == urunisim);

            dataGridView1.DataSource = urunSorguAlis.ToList();
            dataGridView1.Columns[0].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].HeaderText = "Alış Tutarı";
            dataGridView1.Columns[2].HeaderText = "Miktar";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
               toplamalistutar += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value)* Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            label3.Text = toplamalistutar.ToString();
        }
        private void rjButton2_Click(object sender, EventArgs e)
        {
            karzarar = toplamsatistutar - toplamalistutar;
            if (karzarar > 0)
            {
                MessageBox.Show("TEBRİKLER KARDASINIZ!" + Environment.NewLine + "Kar miktarınız " + karzarar + " TL'dir.", "Kar Zarar Durumu");
            }
            else if (karzarar == 0)
            {
                MessageBox.Show("Alımınız ve satımınız birbirine eşit." + Environment.NewLine + "Kar miktarınız " + karzarar + " TL'dir.", "Kar Zarar Durumu");
            }
            else
            {
                MessageBox.Show("DİKKAT ZARARDASINIZ!" + Environment.NewLine + "Zarar miktarınız " + -(karzarar) + " TL'dir.", "Kar Zarar Durumu");
            }
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            RaporlamaSecim raporsec1 = new RaporlamaSecim();    
            raporsec1.Show();
        }
    }
}
