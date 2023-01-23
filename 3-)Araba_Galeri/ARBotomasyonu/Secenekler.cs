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
    public partial class Secenekler : Form
    {
        public Secenekler()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Sube_bilgileri go = new Sube_bilgileri();
            go.Show();
            this.Hide();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            musteri_bilgileri go = new musteri_bilgileri();
            go.Show();
            this.Hide();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Arac_bilgisi go = new Arac_bilgisi();
            go.Show();
            this.Hide();

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Rapor go = new Rapor();
            go.Show();
            this.Hide();
        }
    }
}
