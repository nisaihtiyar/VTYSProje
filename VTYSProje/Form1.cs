using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VTYSProje.Entity;

namespace VTYSProje
{

    public partial class Form1 : Form
    {

   
        public Form1()
        {

            InitializeComponent();
        }
        
        private void Form1_Load(object sender, EventArgs e)
        {
            Context db = new Context();
            //db.Database.Create();

        }
        Entity.Context dbcontext = new Entity.Context();

        private void rjButton1_Click(object sender, EventArgs e)
        {
            string managerId1 = Convert.ToString(textBox1.Text);
            string managerPassword1 = Convert.ToString(textBox2.Text);
            var managerId = dbcontext.tYoneticis.FirstOrDefault(x => x.yKullaniciAdi == managerId1);
            var managerPassword = dbcontext.tYoneticis.FirstOrDefault(x => x.ySifre == managerPassword1);
            if (managerId != null && managerPassword != null)
            {
                this.Hide();
                Anasayfa anasayfa1 = new Anasayfa();
                anasayfa1.Show();
            }
            else
            {
                MessageBox.Show("Lütfen geçerli bir kullanıcı adı veya parola giriniz");
            }
        }

     
    }
}
