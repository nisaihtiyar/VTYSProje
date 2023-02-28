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
    public partial class MusteriBorcOdeme : Form
    {
        public MusteriBorcOdeme()
        {
            InitializeComponent();
        }
        Entity.Context dbcontext = new Entity.Context();

        private void rjButton1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "")
            {

                int sorguId = Convert.ToInt16(textBox1.Text);
                var product = dbcontext.tBorcs.Where(x => x.musteriId == sorguId);
                var product1 = dbcontext.tMusteris.Where(x => x.musteriId == sorguId);

                if (product == null)
                {
                    MessageBox.Show("Girilen müşteri numarasına ait müşteri bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataGridView1.DataSource = product.ToList();
                    dataGridView2.DataSource = product1.ToList();
                }
            }
            else
            {
                MessageBox.Show("Müşteri Id Giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            int mus = Convert.ToInt16(textBox1.Text);
            int borcode = Convert.ToInt16(textBox2.Text);
            var musterisorgu = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == mus);
            if (textBox2.Text != null && musterisorgu != null)
            {
                musterisorgu.odenenMiktar += borcode;
                musterisorgu.kalanBorc = musterisorgu.musteriBorc - musterisorgu.odenenMiktar;
                MessageBox.Show("" + musterisorgu.musteriAdi + " Borcu Güncellendi.", "Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dbcontext.SaveChanges();
            }
            else
            {
                MessageBox.Show("Lütfen güncellemek istediğiniz borç tutarını giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            int sorguId = Convert.ToInt16(textBox1.Text);
            var product1 = dbcontext.tMusteris.Where(x => x.musteriId == sorguId);
            dataGridView2.DataSource = product1.ToList();
            textBox2.Clear();
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            this.Close();
            BorcSecim borcsec1= new BorcSecim();
            borcsec1.Show();
        }
    }
}
