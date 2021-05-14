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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            Form6 intfrm = new Form6();
            intfrm.TopLevel = false;

            bunifuGradientPanel1.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();


           
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            Form5 intfrm = new Form5();
            intfrm.TopLevel = false;

            bunifuGradientPanel1.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            Form1 intfrm = new Form1();
            intfrm.TopLevel = false;

            bunifuGradientPanel1.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void btnLocationM_Click(object sender, EventArgs e)
        {
            this.Hide();
            location f1 = new location();
            f1.Show();
        }

        private void btnSessionM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();
            f1.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void btnTagM_Click(object sender, EventArgs e)
        {

        }
    }
}
