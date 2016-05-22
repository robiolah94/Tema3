using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BL;

namespace Bilete
{
    public partial class AngajatForm : Form
    {
        public AngajatForm(String rez)
        {
            InitializeComponent();
            label1.Text = rez;
        }

        private void label4_Click(object sender, EventArgs e)
        {}

        private void button1_Click(object sender, EventArgs e)
        {
            BileteManager spectacol = new BileteManager();
            Int32 a = Int32.Parse(textBox2.Text);
            Int32 b = Int32.Parse(textBox3.Text);
            spectacol.createBL(textBox1.Text, a,b);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BileteManager bilete = new BileteManager();
            dataGridView1.DataSource = bilete.readBL(textBox4.Text);
        }
    }
}
