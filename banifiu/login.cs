using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banifiu
{
    public partial class login : Form
    {
        public login()
        {
            InitializeComponent();
        }

        private void login_Load(object sender, EventArgs e)
        {
            pn_register.Visible = false;
        }


        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {

            pn_login.Visible = true;
            pn_register.Visible = false;
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            pn_login.Visible = false;
            pn_register.Visible = true;
        }

        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            pn_register.Visible = true;
            pn_login.Visible = false;
        }
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {

            pn_login.Visible = true;
            pn_register.Visible = false;
        }





        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
           
                
        }

      

        private void guna2GradientButton1_Click_1(object sender, EventArgs e)
        {
            String user = txtUser.Text;
            String Password = txtPassword.Text;

            if (user == "admin" & Password == "admin123")
            {
                MessageBox.Show("Login Successfully", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);

                home myNewForm = new home();
                myNewForm.Visible = true;
                this.Hide();
            }

            else if (user == "" && Password == "")
            {
                MessageBox.Show("Please Enter User Name and Password!", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (user == "")
            {
                MessageBox.Show("Please Enter User Name ", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else if (Password == "")
            {
                MessageBox.Show("Please EnterPassword!", "info", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            else
            {
                MessageBox.Show("Incorrect Username or Password", "alter", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
