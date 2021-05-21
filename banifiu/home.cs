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
            Location_home intfrm = new Location_home();
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
            Session_home intfrm = new Session_home();
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

        private void btnLecturerM_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            lecture intfrm = new lecture();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();

        }

        private void btnSubM_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            Subjects intfrm = new Subjects();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void btnTagM_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            Tag_Add intfrm = new Tag_Add();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void btnStudentgrpM_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            Student_add intfrm = new Student_add();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }

        private void btnSessionNotAvailM_Click(object sender, EventArgs e)
        {
            bunifuGradientPanel2.Controls.Clear();
            Se_Not_available intfrm = new Se_Not_available();
            intfrm.TopLevel = false;

            bunifuGradientPanel2.Controls.Add(intfrm);
            intfrm.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            intfrm.Dock = DockStyle.Fill;
            intfrm.Show();
        }
    }


}
