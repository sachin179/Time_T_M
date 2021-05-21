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
    public partial class Session_home : Form
    {
        public Session_home()
        {
            InitializeComponent();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            Form20 intfrm = new Form20();
            intfrm.TopLevel = false;

            bunifuGradientPanel1.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            set_session intfrm = new set_session();
            intfrm.TopLevel = false;

            bunifuGradientPanel1.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }
    }
}
