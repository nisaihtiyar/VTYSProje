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
    public partial class Anasayfa : Form
    {
        public Anasayfa()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            
            StokEkle stokekle1= new StokEkle();
            stokekle1.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            SatisSecim satissec1= new SatisSecim();
            satissec1.Show();   

        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            BorcSecim borcsec1= new BorcSecim();
            borcsec1.Show();
        }

        private void Anasayfa_Load(object sender, EventArgs e)
        {
            label4.Text = DateTime.Now.ToLongDateString();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label5.Text = DateTime.Now.ToLongTimeString();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            RaporlamaSecim rapsec1= new RaporlamaSecim();
            rapsec1.Show();
        }
    }
}
