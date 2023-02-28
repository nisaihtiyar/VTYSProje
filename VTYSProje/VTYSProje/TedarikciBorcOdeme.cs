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
    public partial class TedarikciBorcOdeme : Form
    {
        public TedarikciBorcOdeme()
        {
            InitializeComponent();
        }
        Entity.Context dbcontext = new Entity.Context();

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                int sorguId = Convert.ToInt16(textBox1.Text);
                var product = dbcontext.ttedarikciOdemes.Where(x => x.tedarikciID == sorguId);


                if (product == null)
                {
                    MessageBox.Show("Girilen tedarikçi numarasına ait tedarıkçi bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView1.DataSource = product.ToList();

                }
            }
            else
            {
                MessageBox.Show("Tedarikçi Numarası Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            int sorgulama = Convert.ToInt32(textBox1.Text);
            var tedarikcisorgu = dbcontext.ttedarikciOdemes.FirstOrDefault(x => x.tedarikciID == sorgulama);
            if (textBox2.Text != null)
            {
                tedarikcisorgu.odenenMiktar += Convert.ToInt32(textBox2.Text);
                tedarikcisorgu.kalanMiktar = tedarikcisorgu.toplamBorc - tedarikcisorgu.odenenMiktar;
                MessageBox.Show("" + tedarikcisorgu.tedarikciID + "Numaralı Tedarikçinin Borcu Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz borç tutarını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            textBox2.Clear();
            int sorguId = Convert.ToInt16(textBox1.Text);
            var product = dbcontext.ttedarikciOdemes.Where(x => x.tedarikciID == sorguId);
            dataGridView1.DataSource = product.ToList();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            BorcSecim borcsec1= new BorcSecim();
            borcsec1.Show();
        }
    }
}
