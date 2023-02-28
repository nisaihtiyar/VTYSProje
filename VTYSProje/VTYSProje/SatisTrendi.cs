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
            tarih1 = dateTimePicker1.Value.ToShortDateString();
            tarih2 = dateTimePicker2.Value.ToShortDateString();

            // iki tarih arasinda satilan urun miktarinin siralamasi
            var urunsorgu = dbcontext.tSatiss.Select(x => new
            {
                satistarihi = x.satisTarih,
                urunadi = x.urunAdi,
                satismiktar = x.satisMiktar
            }).Where(x => x.satistarihi == tarih1 && x.satistarihi == tarih2);

        }
    }
}
