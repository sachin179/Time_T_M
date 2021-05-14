using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banifiu
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
            Fillcombo();
        }

        void Fillcombo() {

           
            



        }

        private void Form3_Load(object sender, EventArgs e)
        {
            



        }

        private void bunifuDropdown1_onItemSelected(object sender, EventArgs e)
        {

        }

        private void bunifuDropdown4_onItemSelected(object sender, EventArgs e)
        {

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.roomnameTableAdapter.FillBy(this.addbuildingDataSet.roomname);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
