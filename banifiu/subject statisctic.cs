
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace banifiu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
           


            
        }

        private void bunifuMaterialTextbox1_OnValueChanged(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {

        }

        private void bunifuFlatButton1_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.Show();

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
      

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
         



        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            String sql = "select * from student";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader dr = cmd.ExecuteReader();

            bunifuCustomDataGrid2.Rows.Clear();
            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid3.Rows.Clear();
            bunifuCustomDataGrid5.Rows.Clear();
            bunifuCustomDataGrid5.Rows.Clear();
            while (dr.Read())
            {
                String[] row = { dr["total"].ToString() };
                bunifuCustomDataGrid2.Rows.Add(row);

                String[] row2 = { dr["first"].ToString() };
                bunifuCustomDataGrid1.Rows.Add(row2);

                String[] row3 = { dr["sec"].ToString() };
                bunifuCustomDataGrid3.Rows.Add(row3);

                String[] row4 = { dr["th"].ToString() };
                bunifuCustomDataGrid5.Rows.Add(row4);

                String[] row5 = { dr["forth"].ToString() };
                bunifuCustomDataGrid4.Rows.Add(row5);

            }
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
