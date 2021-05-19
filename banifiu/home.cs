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
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();
        }

        private void btnLocationM_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            location intfrm = new location();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            Form4 intfrm = new Form4();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void btnSessionM_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            Form20 intfrm = new Form20();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void bunifuGradientPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            bunifuGradientPanel2.Controls.Clear();
            home intfrm = new home();
           

            intfrm.Show();
        }

        private void btnWorkM_Click(object sender, EventArgs e)
        {

        }
    }


}
