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
    public partial class Location_home : Form
    {
        public Location_home()
        {
            InitializeComponent();
        }

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            location intfrm = new location();
            intfrm.TopLevel = false;

            bunifuGradientPanel1.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();

        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel1.Controls.Clear();
            location_not_a intfrm = new location_not_a();
            intfrm.TopLevel = false;

            bunifuGradientPanel1.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;

            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();

        }
    }
}
