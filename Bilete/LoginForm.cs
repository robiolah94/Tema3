using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BL;


namespace Bilete
{
    public partial class LoginForm : Form
    {
        public LoginForm()
        {
            InitializeComponent();
        }


        private void button1_Click(object sender, EventArgs e)
        {
           

            AccountManager user = new AccountManager();
            String password = user.encode(textBox2.Text);
            String role = user.getUserBL(textBox1.Text,password);

            //MessageBox.Show(role);
            if (role == "Angajat")
            {
                AngajatForm loginForm = new AngajatForm("Angajat Logat");
                loginForm.Show();
            }
            else if (role == "Admin")
            {
                AdminForm loginForm = new AdminForm("Administrator logat");
                loginForm.Show();
            }
            else
            {
                ErrorForm loginForm = new ErrorForm();
                loginForm.Show();
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ForgotPasswordForm loginForm = new ForgotPasswordForm();
            loginForm.Show();
        }
            
    }
}
