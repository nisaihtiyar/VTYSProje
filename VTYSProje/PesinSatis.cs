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
    public partial class PesinSatis : Form
    {
        public PesinSatis()
        {
            InitializeComponent();
        }

        public double totalPrice = 0;
        Entity.Context dbcontext = new Entity.Context();
        public int stsmusteriID;

        private void rjButton1_Click(object sender, EventArgs e)
        {
            //Ürün miktarı ve girilen barkod numarasına göre ürünümüzü sepete ekleyip ,ürün tutarını toplam tutarımıza ekliyoruz.
            if (textBox2.Text != null)
            {
                long newAddmiktar = Convert.ToInt64(textBox2.Text);
                long newAddId = Convert.ToInt64(textBox1.Text);
                var product = dbcontext.tUruns.SingleOrDefault(x => x.barkodNo == newAddId);
                if (product == null)
                {
                    MessageBox.Show("Girilen barkod no'ya ait ürün bulunamadı.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    string urunAdi = product.urunAdi;
                    string gecis = urunAdi + " x " + textBox2.Text;
                    totalPrice += product.satisFiyat * Convert.ToDouble(textBox2.Text);
                    Sepet.Items.Add(gecis);
                    MessageBox.Show("Ürün sepete eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox4.Text = totalPrice + "";
                }
            }
            else
            {
                MessageBox.Show("Ürün miktarı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox2.Clear();
            textBox1.Clear();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //Ürün silmeyi yönetici şifremiz ile yapıyoruz. Ve toplam tutardan silinen ürünün değerini çıkarıyoruz.
            string itemSelected = Sepet.SelectedItem.ToString();
            string[] selected = itemSelected.Split(' ');
            string selected1 = selected[0];
            int selected2 = Convert.ToInt32(selected[2]);
            var product = dbcontext.tUruns.SingleOrDefault(x => x.urunAdi == selected1);
            var password = dbcontext.tYoneticis.SingleOrDefault(x => x.ySifre == textBox3.Text);
            if (password == null)
            {
                MessageBox.Show("Hatalı şifre girdiniz. Ürün silinemedi!", "Hata!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                double al = Convert.ToDouble(product.satisFiyat);
                totalPrice -= Convert.ToSingle(al * selected2);
                textBox4.Text = totalPrice + "";
                Sepet.Items.Remove(Sepet.SelectedItem);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            //Peşin satış veritabanına ekleniyor.
            var satis = new Entity.tSatis();
            for (int i = 0; i < Sepet.Items.Count; i++)
            {
                string itemSelected = Sepet.Items[i].ToString();
                string[] selected = itemSelected.Split(' ');
                string selected1 = selected[0];
                int selected2 = Convert.ToInt32(selected[2]);
                var urunMiktari12 = dbcontext.tUruns.FirstOrDefault(x => x.urunAdi == selected1);
                
                if (urunMiktari12 != null)
                {
                    urunMiktari12.miktar -= selected2;
                    satis.satisTutar = Convert.ToSingle(urunMiktari12.satisFiyat * selected2);
                    satis.urunAdi = urunMiktari12.urunAdi;
                    satis.satisMiktar = selected2;
                    satis.satisTarih = DateTime.Now.ToShortDateString();
                    dbcontext.tSatiss.Add(satis);
                    dbcontext.SaveChanges();
                    if(urunMiktari12.miktar <= 10)
                    {
                        MessageBox.Show(urunMiktari12.urunAdi+" stokda azalmıştır.Lütfen kontrol ediniz.","Stok Uyarı");
                    }
                }
                else
                {
                    MessageBox.Show("Hata");
                }
            }
            dbcontext.SaveChanges();
            Sepet.Items.Clear();

            totalPrice = 0;
            textBox4.Clear();
            
            MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            SatisSecim satsec1 = new SatisSecim();
            satsec1.Show();
        }
    }
}
