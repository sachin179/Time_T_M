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
    public partial class location : Form
    {
        public location()
        {
            InitializeComponent();

            dataGridView1.Columns.Add("id", "ID");
            dataGridView1.Columns.Add("bname", "Buildimg name");
            dataGridView1.Columns.Add("rname", "room name");
            dataGridView1.Columns.Add("rtype", "room type");

            dataGridView1.BorderStyle = BorderStyle.None;
            dataGridView1.AlternatingRowsDefaultCellStyle.BackColor = Color.FromArgb(238, 239, 249);
            dataGridView1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.DarkTurquoise;
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.WhiteSmoke;
            dataGridView1.BackgroundColor = Color.White;

            dataGridView1.EnableHeadersVisualStyles = false;
            dataGridView1.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridView1.ColumnHeadersDefaultCellStyle.BackColor = Color.FromArgb(20, 25, 72);
            dataGridView1.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;



        }

        private void bunifuCustomLabel7_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomLabel8_Click(object sender, EventArgs e)
        {

        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MessageBox.Show("connectionsuccess full!");

                String bname = bname1.Text;
                String rname = roomntxt.Text;
                String rtype = buildTtxt.Text;

                String sql = "insert into locationt(bname,rname,rtype) values ('" + bname + " ','" + rname + " ','" + rtype + " ')";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       

       
        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            String sql = "select * from locationt";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader dr = cmd.ExecuteReader();

            dataGridView1.Rows.Clear();
            while (dr.Read())
            {
                String []row = { dr["id"].ToString(), dr["bname"].ToString(), dr["rname"].ToString(), dr["rtype"].ToString() };
                dataGridView1.Rows.Add(row);
            }

          
            



        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        

        }
        //load DATA
        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
               

                String id = txtid.Text;
                

                String sql = "select * from locationt where id = '" +id+ "' ";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                MySqlDataReader dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    

                    bname1.Text = dr["bname"].ToString();
                    roomntxt.Text = dr["rname"].ToString();
                    buildTtxt.Text = dr["rtype"].ToString();
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

          

        }
        //update
        private void bunifuThinButton25_Click(object sender, EventArgs e)
        {

            try
            {
                String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MessageBox.Show("connectionsuccess full!");

                String id = txtid.Text;
                String bname = bname1.Text;
                String rname = roomntxt.Text;
                String rtype = buildTtxt.Text;

                String sql = "update locationt set bname = ' " + bname + " ' ,rname = ' " + rname + " ',rtype= ' " + rtype  + " '  where id =' " +id+" ' ";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

            


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //delete

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {

            try
            {
                String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
                MessageBox.Show("connectionsuccess full!");

                String id = txtid.Text;

                String sql = "delete from locationt  where id =' " + id + " ' ";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f1 = new Form4();
            f1.Show();
        }

        private void btnSessionNotAvailM_Click_1(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f1 = new Form3();

            f1.Show();
        }

        private void btnTagM_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCustomTextbox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {
            txtid.Clear();
                bname1.Clear();
                roomntxt.Clear();
            buildTtxt.Clear();
        }

    }
    
}
