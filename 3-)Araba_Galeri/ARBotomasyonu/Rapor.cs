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
    public partial class Rapor : Form
    {
        public Rapor()
        {
            InitializeComponent();
        }
        ARBEntities1 con = new ARBEntities1();

        private void Rapor_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Secenekler go = new Secenekler();
            go.Show();
            this.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
