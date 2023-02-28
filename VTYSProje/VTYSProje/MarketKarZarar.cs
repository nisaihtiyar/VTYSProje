using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTYSProje.Entity;

namespace VTYSProje
{
    public partial class MarketKarZarar : Form
    {
        public MarketKarZarar()
        {
            InitializeComponent();
        }
        Entity.Context dbcontext = new Entity.Context();
        int toplamsatismiktar;
        int toplamsatis;
        int toplamalis;
        int karzarar;
      
        private void UrunKarZarar_Load(object sender, EventArgs e)
        {
            //Alınan tutar hesabı yapılır.
            var urunSorguAlis = dbcontext.tTedarikcis.Select(x => new
            {
                tedarikci = x.tedarikciId,
                borcmiktari = x.borcMiktar
            }) ;
            dataGridView2.DataSource = urunSorguAlis.ToList();
            dataGridView2.Columns[0].HeaderText = "Tedarikçi No";
            dataGridView2.Columns[1].HeaderText = "Toplam Alış Tutarı";

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                toplamalis += Convert.ToInt32(dataGridView2.Rows[i].Cells[1].Value);
            }

            //Satilan ürün miktar ve tutar hesabı yapılır.
            var urunSorgu = dbcontext.tSatiss.Select(x => new {
                urunadi = x.urunAdi,
                satisfiyati = x.satisTutar,
                miktari = x.satisMiktar

            });
            dataGridView1.DataSource = urunSorgu.ToList();
            dataGridView1.Columns[0].HeaderText = "Ürün Adı";
            dataGridView1.Columns[1].HeaderText = "Toplam Satış Tutarı";
            dataGridView1.Columns[2].HeaderText = "Satış Miktarı";

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplamsatismiktar += Convert.ToInt32(dataGridView1.Rows[i].Cells[2].Value);
            }
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                toplamsatis += Convert.ToInt32(dataGridView1.Rows[i].Cells[1].Value);
            }
            label5.Text = toplamalis.ToString();
            label6.Text = toplamsatis.ToString();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            karzarar = toplamsatis - toplamalis;
            if(karzarar> 0)
            {
                MessageBox.Show("TEBRİKLER KARDASINIZ!" + Environment.NewLine + "Kar miktarınız " + karzarar + " TL'dir.", "Kar Zarar Durumu");
            }
            else if(karzarar ==0)
            {
                MessageBox.Show("Alımınız ve satımınız birbirine eşit." + Environment.NewLine + "Kar miktarınız " + karzarar + " TL'dir.", "Kar Zarar Durumu");
            }
            else
            {
                MessageBox.Show("DİKKAT ZARARDASINIZ!" + Environment.NewLine + "Zarar miktarınız " + -(karzarar) + " TL'dir.","Kar Zarar Durumu");
            }
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            RaporlamaSecim rapsec1 = new RaporlamaSecim();
            rapsec1.Show();
        }
    }
}
