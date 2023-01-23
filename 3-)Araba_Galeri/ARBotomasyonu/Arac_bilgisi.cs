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
    public partial class Arac_bilgisi : Form
    {
        public Arac_bilgisi()
        {
            InitializeComponent();
        }
        ARBEntities1 con = new ARBEntities1();
        public void Liste()
        {
            dataGridView1.DataSource = con.Araclars.ToList();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow satir = dataGridView1.CurrentRow;
            textBox1.Tag = satir.Cells["AracNo"].Value.ToString();
            textBox1.Text = satir.Cells["AracFiyat"].Value.ToString();
            textBox2.Text = satir.Cells["AracAdet"].Value.ToString();
            textBox3.Text = satir.Cells["AracMarka"].Value.ToString();
            textBox4.Text = satir.Cells["AracModel"].Value.ToString();
            textBox8.Text= satir.Cells["AracYil"].Value.ToString();
            textBox7.Text= satir.Cells["AracOzellik"].Value.ToString();
            textBox6.Text = satir.Cells["AracMotor"].Value.ToString();
            textBox5.Text = satir.Cells["AracPaket"].Value.ToString();
            textBox10.Text = satir.Cells["AracRenk"].Value.ToString();
            comboBox1.Text = satir.Cells["SubeNo"].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Liste();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Araclar save = new Araclar();
            save.AracFiyat = Convert.ToDecimal(textBox1.Text);
            save.AracAdet = Convert.ToInt32(textBox2.Text);
            save.AracMarka =textBox3.Text;
            save.AracModel = textBox4.Text;
            save.AracYil = Convert.ToInt32(textBox8.Text);
            save.AracOzellik= textBox7.Text;
            save.AracMotor= textBox6.Text;
            save.AracPaket = textBox5.Text;
            save.AracRenk = textBox10.Text;
            save.SubeNo = Convert.ToInt32(comboBox1.Text);
            con.Araclars.Add(save);
            con.SaveChanges();
            Liste();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(textBox1.Tag);
            var sil = con.Araclars.Where(x => x.AracNo == ano).FirstOrDefault();
            con.Araclars.Remove(sil);
            con.SaveChanges();
            Liste();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            int ano = Convert.ToInt32(textBox1.Tag);
            var yenile = con.Araclars.Where(x => x.AracNo == ano).FirstOrDefault();
            yenile.AracFiyat = Convert.ToDecimal(textBox1.Text);
            yenile.AracAdet = Convert.ToInt32(textBox2.Text);
            yenile.AracMarka = textBox3.Text;
            yenile.AracModel = textBox4.Text;
            yenile.AracYil = Convert.ToInt32(textBox8.Text);
            yenile.AracOzellik = textBox7.Text;
            yenile.AracMotor = textBox6.Text;
            yenile.AracPaket = textBox5.Text;
            yenile.AracRenk = textBox10.Text;
            yenile.SubeNo = Convert.ToInt32(comboBox1.Text);
            con.SaveChanges();
            Liste();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Secenekler go = new Secenekler();
            go.Show();
            this.Hide();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Arac_bilgisi_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = con.Subelers.ToList();
            comboBox1.ValueMember = "SubeNo";
           
        }
    }
}
