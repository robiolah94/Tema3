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
    public partial class AdminForm : Form
    {
        public AdminForm(String rez)
        {
            InitializeComponent();
            label1.Text = rez;

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            AccountManager account = new AccountManager();
            String password = account.encode(textBox2.Text);
            account.createAngajatBL(textBox1.Text,password);
        }


        private void button2_Click(object sender, EventArgs e)
        {
            SpectacolManager spectacol = new  SpectacolManager();
            Int32 a = Int32.Parse(textBox7.Text);
            spectacol.createBL(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, a);

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SpectacolManager spectacol = new SpectacolManager();
            Int32 a = Int32.Parse(textBox7.Text);
            spectacol.updateBL(textBox3.Text, textBox4.Text, textBox5.Text, textBox6.Text, a);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SpectacolManager spectacol = new SpectacolManager();
            spectacol.deleteBL(textBox3.Text);

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            SpectacolManager spectacol = new SpectacolManager();
            dataGridView1.DataSource = spectacol.readBL();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            FactoryExport factory = new FactoryExport();
            Export Csv = factory.getExporter("CSV");
            Csv.export();
            MessageBox.Show("Csv created succesfully");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            FactoryExport factory = new FactoryExport();
            Export JSON = factory.getExporter("CSV");
            JSON.export();
            MessageBox.Show("JSON created succesfully");
        }
    }
}
