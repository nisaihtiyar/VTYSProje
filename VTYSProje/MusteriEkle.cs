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
    public partial class MusteriEkle : Form
    {
        public MusteriEkle()
        {
            InitializeComponent();
        }
        Entity.Context dbcontext = new Entity.Context();

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string tarih = dateTimePicker1.Value.ToShortDateString();
            var musteri = new Entity.tMusteri();
            musteri.musteriId = 0;
            musteri.musteriAdi = textBox1.Text;
            musteri.musteriSoyadi = textBox2.Text;
            musteri.musteriGSM = textBox3.Text;
            musteri.kayitTarihi = tarih;
            musteri.musteriBorc = 0;
            dbcontext.tMusteris.Add(musteri);
            dbcontext.SaveChanges();
            MessageBox.Show("Müşteri Eklendi. Numarası : " + musteri.musteriId + "", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }
    }
 }

