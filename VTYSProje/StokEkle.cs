using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VTYSProje
{
    public partial class StokEkle : Form
    {
        public StokEkle()
        {
            InitializeComponent();
        }

        private void StokEkle_Load(object sender, EventArgs e)
        {
            // TODO: Bu kod satırı 'vTYSProjeDataSet.tIrsaliyes' tablosuna veri yükler. Bunu gerektiği şekilde taşıyabilir, veya kaldırabilirsiniz.
            this.tIrsaliyesTableAdapter.Fill(this.vTYSProjeDataSet.tIrsaliyes);

        }
        Entity.Context dbcontext = new Entity.Context();
        public double karMiktari;
        private void rjButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog file = new OpenFileDialog();
            //OpenFileDialog acildiginda masaustu acılacak
            file.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            //filtre olarak .txt dosyalarını bulacak
            file.Filter = "Text Files|*.txt";
            file.ShowDialog();
            //Okunacak dosyanın yolu
            string path = file.FileName;
            //Dosyadan okuma işlemi satır satır gerçekleştiriliyor.
            string[] satir = System.IO.File.ReadAllLines(path, Encoding.GetEncoding("windows-1254"));
            //Dosya yolunu kontrol için ekrana bastırıyorum
            MessageBox.Show("Seçilen dosyanın yolu : \n" + file.FileName, "Dosya başarıyla seçildi.", MessageBoxButtons.OK, MessageBoxIcon.Information);
            file.Reset();
            for (int i = 0; i < satir.Length; i += 7)
            {
                //irsaliye eklemesini yapıyoruz
                var irsaliye = new Entity.tIrsaliye();
                var urun = new Entity.tUrun();
                var tedarikci = new Entity.tTedarikci();
                irsaliye.irsaliyeID = Convert.ToInt16(satir[i]);
                irsaliye.girisTarih = Convert.ToDateTime(satir[i + 1]);
                irsaliye.urunId = Convert.ToInt16(satir[i + 2]);
                irsaliye.girdiFiyat = (float)Convert.ToDouble(satir[i + 3]);
                irsaliye.miktar = Convert.ToInt16(satir[i + 4]);
                irsaliye.tedarikciId = Convert.ToInt16(satir[i + 5]);
                irsaliye.urunAdi = Convert.ToString(satir[i + 6]);
                dbcontext.tIrsaliyes.Add(irsaliye);
                var product = dbcontext.tUruns.FirstOrDefault(x => x.urunAdi == irsaliye.urunAdi);
                if (product == null)
                {
                    //Ürün yoksa ürün eklemesini yapıyoruz
                    urun.urunId = irsaliye.urunId;
                    urun.barkodNo = Convert.ToInt64("555" + irsaliye.urunId + "000");
                    urun.urunAdi = irsaliye.urunAdi;
                    urun.miktar = irsaliye.miktar;
                    double cevrim = Convert.ToDouble(irsaliye.girdiFiyat + karMiktari);
                    cevrim = Math.Round(cevrim, 2);
                    urun.satisFiyat = cevrim;
                    dbcontext.tUruns.Add(urun);
                    if (i == satir.Length - 7)
                    {
                        MessageBox.Show("Ürün kayıt edildi.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    //Ürün varsa güncellemesini yapıyoruz
                    product.miktar += irsaliye.miktar;
                    product.satisFiyat = (float)Convert.ToDouble(irsaliye.girdiFiyat + karMiktari);
                    if (i == satir.Length - 7)
                    {
                        MessageBox.Show("Ürün güncellendi", "Stok Güncelleme", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                dbcontext.SaveChanges();
                //Tedarikci yoksa tedarikci ekliyoruz
                tedarikci.tedarikciId = irsaliye.tedarikciId;
                tedarikci.borcMiktar = (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                tedarikci.girisTarihi = DateTime.Now.ToShortDateString();
                dbcontext.tTedarikcis.Add(tedarikci);
                dbcontext.SaveChanges();
                var tedarikciodeme1 = new Entity.ttedarikciOdeme();
                var tedarikciodeme = dbcontext.ttedarikciOdemes.FirstOrDefault(x => x.tedarikciID == irsaliye.tedarikciId);
                if (tedarikciodeme == null)
                {
                    tedarikciodeme1.tedarikciID = irsaliye.tedarikciId;
                    tedarikciodeme1.toplamBorc = (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    dbcontext.ttedarikciOdemes.Add(tedarikciodeme1);
                    dbcontext.SaveChanges();
                }
                else
                {
                    tedarikciodeme.toplamBorc += (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    tedarikciodeme.kalanMiktar += (float)Convert.ToDouble(irsaliye.miktar * irsaliye.girdiFiyat);
                    dbcontext.SaveChanges();
                }
                dataGridView1.Refresh();
            }
        }

        private void rjButton3_Click(object sender, EventArgs e)
        {
            karMiktari = Convert.ToDouble(textBox1.Text);
        }

        private void rjButton2_Click(object sender, EventArgs e)
        {
            this.Close();
            StokGörüntüleme stokgor1 = new StokGörüntüleme();
            stokgor1.Show();
        }

        private void rjButton4_Click(object sender, EventArgs e)
        {
            this.Close();
            

        }

        private void rjButton5_Click(object sender, EventArgs e)
        {
            this.Close();
            TedarikciTopluBorc tedborc1 = new TedarikciTopluBorc();
            tedborc1.Show();
        }
    }
}
