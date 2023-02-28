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
    public partial class VeresiyeSatis : Form
    {
        public VeresiyeSatis()
        {
            InitializeComponent();
        }

        public double totalPrice = 0;
        Entity.Context dbcontext = new Entity.Context();
        public int stsmusteriID;

        private void rjButton1_Click(object sender, EventArgs e)
        {

            //Ürün miktarı ve girilen barkod numarasına göre ürünümüzü sepete ekleyip ,ürün tutarını toplam tutarımıza ekliyoruz.
            if (textBox3.Text != null)
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
                    listBox1.Items.Add(gecis);
                    MessageBox.Show("Ürün sepete eklendi", "Eklendi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    textBox4.Text = totalPrice + "";
                }
            }
            else
            {
                MessageBox.Show("Ürün miktarı giriniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            //Ürün silmeyi yönetici şifremiz ile yapıyoruz. Ve toplam tutardan silinen ürünün değerini çıkarıyoruz.
            string itemSelected = listBox1.SelectedItem.ToString();
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
                listBox1.Items.Remove(listBox1.SelectedItem);
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            //veresiye satış ,satış veritabanına ekleniyor.
            //Müşteri mevcut değilse yeni müşteri oluşturuluyor. Ardından borç ekleniyor.
            //Mevcut bir müşteri ise borcuna ekleme yapılıyor.
            stsmusteriID = Convert.ToInt32(textBox5.Text);
            var satis = new Entity.tSatis();
            var musterii = dbcontext.tMusteris.FirstOrDefault(x => x.musteriId == stsmusteriID);
            if (musterii == null)
            {
                MessageBox.Show("Lütfen yeni müşteri oluşturunuz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                for (int i = 2; i < listBox1.Items.Count; i++)
                {
                    string itemSelected = listBox1.Items[i].ToString();
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
                        if (urunMiktari12.miktar <= 10)
                        {
                            MessageBox.Show(urunMiktari12.urunAdi + " stokda azalmıştır.Lütfen kontrol ediniz.");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Hata");
                    }
                }
                var borc = new Entity.tBorc();
                borc.musteriId = musterii.musteriId;
                borc.borcMiktar = Convert.ToSingle(totalPrice);
                borc.borcTarihi = DateTime.Now.ToShortDateString();
                musterii.musteriBorc += Convert.ToSingle(totalPrice);  // - odenen miktarı 0 a çekiyorsun
                musterii.kalanBorc += Convert.ToSingle(totalPrice);
                dbcontext.tBorcs.Add(borc);
                dbcontext.SaveChanges();
                listBox1.Items.Clear();
                totalPrice = 0;
                listBox1.Items.Clear();
                listBox1.Items.Add("Sepet");
                listBox1.Items.Add("----------");
                totalPrice = 0;

                MessageBox.Show("Satış Tamamlandı", "Tamamlandı", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                textBox5.Clear();
                textBox4.Clear();
            }
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            MusteriEkle musekle1= new MusteriEkle();
            musekle1.Show();
        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            SatisSecim satissec= new SatisSecim(); 
            satissec.Show();
        }
    }
}
