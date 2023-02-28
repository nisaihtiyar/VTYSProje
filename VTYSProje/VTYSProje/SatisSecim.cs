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
    public partial class SatisSecim : Form
    {
        public SatisSecim()
        {
            InitializeComponent();
        }

        private void rjButton1_Click(object sender, EventArgs e)
        {
            this.Close();
            PesinSatis pesinsat1= new PesinSatis();
            pesinsat1.Show();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            VeresiyeSatis veresiyesat1= new VeresiyeSatis();
            veresiyesat1.Show();
        }

     
    }
}
