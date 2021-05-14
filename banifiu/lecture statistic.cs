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
    public partial class Form6 : Form
    {
        public Form6()
        {
            InitializeComponent();
        }

        private void bunifuCustomLabel1_Click(object sender, EventArgs e)
        {

        }

        private void Form6_Load(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuTextbox1_OnTextChange(object sender, EventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon2_MouseDoubleClick(object sender, MouseEventArgs e)
        {

        }

        private void notifyIcon1_MouseDoubleClick_1(object sender, MouseEventArgs e)
        {

        }

        private void btnSessionNotAvailM_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();
            
            f1.Show();
        }

        private void btnLocationM_Click(object sender, EventArgs e)
        {
            this.Hide();
            location f1 = new location();
            f1.Show();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.Show();

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            String sql = "select * from lecture";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader dr = cmd.ExecuteReader();

            bunifuCustomDataGrid1.Rows.Clear();
            bunifuCustomDataGrid2.Rows.Clear();
            bunifuCustomDataGrid3.Rows.Clear();
            bunifuCustomDataGrid6.Rows.Clear();
            bunifuCustomDataGrid5.Rows.Clear();
            bunifuCustomDataGrid4.Rows.Clear();
            while (dr.Read())
            {
                String[] row = { dr["total"].ToString() };
                bunifuCustomDataGrid1.Rows.Add(row);

                String[] row2 = { dr["pro"].ToString() };
                bunifuCustomDataGrid2.Rows.Add(row2);

                String[] row3 = { dr["asspaf"].ToString() };
                bunifuCustomDataGrid3.Rows.Add(row3);

                String[] row4 = { dr["senlec"].ToString() };
                bunifuCustomDataGrid6.Rows.Add(row4);

                String[] row5 = { dr["lec"].ToString() };
                bunifuCustomDataGrid5.Rows.Add(row5);

                String[] row6 = { dr["asslec"].ToString() };
                bunifuCustomDataGrid4.Rows.Add(row6);

            }
        }
        }
}
