using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARBotomasyonu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ARBEntities1 con = new ARBEntities1();
        private bool GirisYap(string ad,string sifre)
        {
            var sorgu = from p in con.Kayits
                        where p.KullaniciAdi == ad && p.Sifre == sifre
                        select p;
            if (sorgu.Any())
            {
                return true;
            }
            else
            {
                return false;
            }
            textBox1.Clear();
            textBox2.Clear();
        }

        

        private void Form1_Load(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (GirisYap(textBox1.Text, textBox2.Text))
            {
                Secenekler secenekleregit = new Secenekler();
                secenekleregit.ShowDialog();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı Adı veya Şifre Hatalı");
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            groupBox2.Visible = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Kayit save = new Kayit();
            save.KullaniciAdi =textBox3.Text;
            save.Sifre = textBox4.Text;
            save.Mail= textBox5.Text;
            save.Telefon = maskedTextBox1.Text;         
            con.Kayits.Add(save);
            con.SaveChanges();         
        }
    }
}
