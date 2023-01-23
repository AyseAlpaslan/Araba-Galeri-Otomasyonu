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
    public partial class musteri_bilgileri : Form
    {
        
        public musteri_bilgileri()
        {
            InitializeComponent();
        }
        ARBEntities1 con = new ARBEntities1();
        public void Liste()
        {
            dataGridView1.DataSource = con.Musterilers.ToList();

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Musteriler save = new Musteriler();
            save.MusteriAdSoyad = textBox1.Text;
            save.MusteriTelefon = maskedTextBox1.Text;
            save.MusteriYas = Convert.ToInt32(textBox2.Text);
            save.MusteriBakiye = Convert.ToDecimal(textBox3.Text);
            con.Musterilers.Add(save);
            con.SaveChanges();
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int mno = Convert.ToInt32(textBox1.Tag);
            var yenile = con.Musterilers.Where(x => x.MusteriNo == mno).FirstOrDefault();
            yenile.MusteriAdSoyad = textBox1.Text;
            yenile.MusteriTelefon = maskedTextBox1.Text;
            yenile.MusteriYas = Convert.ToInt32(textBox2.Text);
            yenile.MusteriBakiye = Convert.ToDecimal(textBox3.Text);
            con.SaveChanges();
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int mno = Convert.ToInt32(textBox1.Tag);
            var sil = con.Musterilers.Where(x => x.MusteriNo == mno).FirstOrDefault();
            con.Musterilers.Remove(sil);
            con.SaveChanges();
            Liste();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["MusteriNo"].Value.ToString();
            textBox1.Text = satir.Cells["MusteriAdSoyad"].Value.ToString();
            maskedTextBox1.Text = satir.Cells["MusteriTelefon"].Value.ToString();
            textBox2.Text = satir.Cells["MusteriYas"].Value.ToString();
            textBox3.Text = satir.Cells["MusteriBakiye"].Value.ToString();

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Secenekler go = new Secenekler();
            go.Show();
            this.Hide();
        }

        private void musteri_bilgileri_Load(object sender, EventArgs e)
        {

        }
    }
}
