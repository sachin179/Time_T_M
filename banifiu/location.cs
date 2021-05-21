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

        }


        private void bunifuThinButton23_Click(object sender, EventArgs e)
        {
            try
            {
                String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = addlocation ";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
               // MessageBox.Show("connectionsuccess full!");

                String bname = bname1.Text;
                String rname = roomntxt.Text;
                String rtype = buildTtxt.Text;

                String sql = "insert into locationt(bname,rname,rtype) values ('" + bname + " ','" + rname + " ','" + rtype + " ')";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                load_l_table();


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        public void load_l_table()

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
                String[] row = { dr["id"].ToString(), dr["bname"].ToString(), dr["rname"].ToString(), dr["rtype"].ToString() };
                dataGridView1.Rows.Add(row);
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
              //  MessageBox.Show("connectionsuccess full!");

                String id = txtid.Text;
                String bname = bname1.Text;
                String rname = roomntxt.Text;
                String rtype = buildTtxt.Text;

                String sql = "update locationt set bname = ' " + bname + " ' ,rname = ' " + rname + " ',rtype= ' " + rtype  + " '  where id =' " +id+" ' ";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                load_l_table();


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
            //    MessageBox.Show("connectionsuccess full!");

                String id = txtid.Text;

                String sql = "delete from locationt  where id =' " + id + " ' ";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();

                load_l_table();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

     

      

        private void bunifuThinButton26_Click(object sender, EventArgs e)
        {


            txtid.Text = string.Empty;
            bname1.Text = string.Empty;
            roomntxt.Text = string.Empty;
            buildTtxt.Text = string.Empty;
       
        }

        private void location_Load(object sender, EventArgs e)
        {
            load_l_table();
        }

    

        private void dataGridView1_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridView1.CurrentRow.Index != -1)
                {
                    txtid.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                    bname1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                    roomntxt.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                    buildTtxt.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();


                }
            }
            catch
            {

            }

        }
    }
    
}
