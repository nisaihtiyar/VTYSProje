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
    public partial class RaporlamaSecim : Form
    {
        public RaporlamaSecim()
        {
            InitializeComponent();
        }

        private void rjButton6_Click(object sender, EventArgs e)
        {
            this.Close();
            SatisSiralama satisSiralama= new SatisSiralama();
            satisSiralama.Show();

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            TopluMusteriBorc topluMusteriBorc= new TopluMusteriBorc();
            topluMusteriBorc.Show();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            MarketKarZarar karzarar1 = new MarketKarZarar();
            karzarar1.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            UrunKarZarar urunkarzarar1 = new UrunKarZarar();
            urunkarzarar1.Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            MusteriBazlıRapor musrap1 = new MusteriBazlıRapor();
            musrap1.Show();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            SatisTrendi satistrend1 = new SatisTrendi();
            satistrend1.Show();
        }
    }
}
