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
    public partial class Sube_bilgileri : Form
    {
        public Sube_bilgileri()
        {
            InitializeComponent();
        }
        ARBEntities1 con = new ARBEntities1();

        public void Liste()
        {
            dataGridView1.DataSource = con.Subelers.ToList();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Subeler save = new Subeler();
            save.SubeAdi = textBox1.Text;
            save.CalisanSayisi = Convert.ToInt32(textBox2.Text);
            save.SubeCiro = Convert.ToDecimal(textBox3.Text);
            save.MusteriNo = Convert.ToInt32(comboBox1.Text);
            con.Subelers.Add(save);
            con.SaveChanges();
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int sno = Convert.ToInt32(textBox1.Tag);
            var yenile = con.Subelers.Where(x => x.SubeNo == sno).FirstOrDefault();
            yenile.SubeAdi = textBox1.Text;
            yenile.CalisanSayisi = Convert.ToInt32(textBox2.Text);
            yenile.SubeCiro = Convert.ToDecimal(textBox3.Text);
            yenile.MusteriNo = Convert.ToInt32(comboBox1.Text);
            con.SaveChanges();
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int sno = Convert.ToInt32(textBox1.Tag);
            var sil = con.Subelers.Where(x => x.SubeNo == sno).FirstOrDefault();
            con.Subelers.Remove(sil);
            con.SaveChanges();
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["SubeNo"].Value.ToString();
            textBox1.Text = satir.Cells["SubeAdi"].Value.ToString();
            textBox2.Text = satir.Cells["CalisanSayisi"].Value.ToString();
            textBox3.Text = satir.Cells["SubeCiro"].Value.ToString();
            comboBox1.Text = satir.Cells["MusteriNo"].Value.ToString();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Secenekler go = new Secenekler();
            go.Show();
            this.Hide();
        }

        private void Sube_bilgileri_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = con.Musterilers.ToList();
            comboBox1.ValueMember = "MusteriNo";
            //comboBox1.DisplayMember = "MusteriAdSoyad";
        }
    }
}
