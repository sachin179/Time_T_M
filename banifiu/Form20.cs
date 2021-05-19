using MySql.Data.MySqlClient;
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
    public partial class Form20 : Form
    {
        connect2 con2 = new connect2();//call class connect
        MySqlCommand cmd;
        // MySqlDataReader reader;
        MySqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;

        connect con = new connect();

        MySqlCommand cmd2;
         MySqlDataReader reader2;
        MySqlDataAdapter adapter2;
        DataTable dt2;
        DataSet ds2;


        public Form20()
        {
            InitializeComponent();

   
        }

        private void bunifuGradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        public void loadgrpID()
        {
          
                con.connection();
               // MessageBox.Show("connectionsuccess full!");
                cmd = new MySqlCommand("select * from locationt", con.con);
                adapter = new MySqlDataAdapter(cmd);
                ds = new DataSet();
                adapter.Fill(ds);
                //dataSession.DataSource = ds;
                con.con.Close();

                comboBox2.DataSource = ds.Tables[0];
                comboBox2.DisplayMember = "rname";
                comboBox2.ValueMember = "id";
     

        }

        public void subgroup_load()
        {
           
                con2.connection();
            //   MessageBox.Show("connectionsuccess full!");
                cmd2 = new MySqlCommand("select * from consecutive", con2.con2);
                adapter2 = new MySqlDataAdapter(cmd2);
                ds2 = new DataSet();
                adapter2.Fill(ds2);
                //dataSession.DataSource = ds;
                con2.con2.Close();

                comboBox3.DataSource = ds2.Tables[0];
                comboBox3.DisplayMember = "subgrpID";
                comboBox3.ValueMember = "consecutiveID";
     

        }

        public void Tag_load()
        {
        
        //    {
                con2.connection();
              //  MessageBox.Show("connectionsuccess full!");
                cmd2 = new MySqlCommand("select * from tagadd", con2.con2);
                adapter2 = new MySqlDataAdapter(cmd2);
                ds2 = new DataSet();
                adapter2.Fill(ds2);
                //dataSession.DataSource = ds;
                con2.con2.Close();

                comboBox4.DataSource = ds2.Tables[0];
                comboBox4.DisplayMember = "tagName";
                comboBox4.ValueMember = "tagID";
     

        }
        



               public void lecture_secound_load()
        {

            con2.connection();
            //   MessageBox.Show("connectionsuccess full!");
            cmd2 = new MySqlCommand("select * from lecturer", con2.con2);
            adapter2 = new MySqlDataAdapter(cmd2);
            ds2 = new DataSet();
            adapter2.Fill(ds2);
            //dataSession.DataSource = ds;
            con2.con2.Close();

            comboBox8.DataSource = ds2.Tables[0];
            comboBox8.DisplayMember = "lecturerName";
            comboBox8.ValueMember = "id";


        }


        public void lecture_load()
        {
          
                con2.connection();
             //   MessageBox.Show("connectionsuccess full!");
                cmd2 = new MySqlCommand("select * from lecturer", con2.con2);
                adapter2 = new MySqlDataAdapter(cmd2);
                ds2 = new DataSet();
                adapter2.Fill(ds2);
                //dataSession.DataSource = ds;
                con2.con2.Close();

                comboBox5.DataSource = ds2.Tables[0];
                comboBox5.DisplayMember = "lecturerName";
                comboBox5.ValueMember = "id";
    

        }


        public void day_hours_load()
        {
          
            con2.connection();
            //  MessageBox.Show("connectionsuccess full!");
            cmd2 = new MySqlCommand("select * from workday", con2.con2);
            adapter2 = new MySqlDataAdapter(cmd2);

            ds2 = new DataSet();
            adapter2.Fill(ds2);
            //dataSession.DataSource = ds;
            con2.con2.Close();

            comboBox6.DataSource = ds2.Tables[0];
            comboBox6.DisplayMember = "D/time";
            comboBox6.ValueMember = "id";


        }



        public void Subject_load()
        {
           
                con2.connection();
              //  MessageBox.Show("connectionsuccess full!");
                cmd2 = new MySqlCommand("select * from subject", con2.con2);
                adapter2 = new MySqlDataAdapter(cmd2);
            
                ds2 = new DataSet();
                adapter2.Fill(ds2);
                //dataSession.DataSource = ds;
                con2.con2.Close();

                comboBox1.DataSource = ds2.Tables[0];
                comboBox1.DisplayMember = "subjectName";
                comboBox1.ValueMember = "id";


        }

        private void Form20_Load(object sender, EventArgs e)
        {
            loadgrpID();
            subgroup_load();
            Tag_load();
            lecture_load();
            Subject_load();
            day_hours_load();
            loadNtable();
            loadNtable_con();
            lecture_secound_load();

        }

        public void loadNtable()
        {
           

            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = studentdb ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            String sql = "select * from new_table";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader dr = cmd.ExecuteReader();


            bunifuCustomDataGrid2.Rows.Clear(); 
            while (dr.Read())
            {
                String[] row = { dr["id"].ToString(), dr["lecture_1"].ToString(), dr["lecture_2"].ToString(), dr["subject"].ToString(), dr["sub_code"].ToString(), dr["tag"].ToString(), dr["room"].ToString(), dr["sub_group"].ToString(), dr["N_Of_Student"].ToString(), dr["Day_and_time"].ToString() };
                bunifuCustomDataGrid2.Rows.Add(row);
            }
        }





        public void loadNtable_con()
        {
          

            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = studentdb ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();

            String sql = "select * from new_table1";//consi

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            MySqlDataReader dr = cmd.ExecuteReader();


            bunifuCustomDataGrid3.Rows.Clear(); 
            while (dr.Read())
            {
                String[] row = { dr["id"].ToString(), dr["lecture_1"].ToString(), dr["lecture_2"].ToString(), dr["subject"].ToString(), dr["sub_code"].ToString(), dr["tag"].ToString(), dr["room"].ToString(), dr["sub_group"].ToString(), dr["N_Of_Student"].ToString(), dr["Day_and_time"].ToString() };
                bunifuCustomDataGrid3.Rows.Add(row);
            }
        }





        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_DoubleClick(object sender, EventArgs e)
        {
            string tname = comboBox1.Text;

            if (tname == "MC")
            {
                textBox1.Text = "IT1010";
            }
            else if (tname == "NDM")
            {
                textBox1.Text = "IT3020";
            }
            else if (tname == "ITP")
            {
                textBox1.Text = "IT2030";
            }
            //cmbTrel.Enabled = false;
        }

        private void bunifuCustomDataGrid2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            loadNtable();
            loadNtable_con();

            try
                {
                    String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = studentdb ";
                    MySqlConnection con = new MySqlConnection(connectionString);
                    con.Open();
                   // MessageBox.Show("connectionsuccess full!");

                    String lecture_1 = comboBox5.Text;
                      String lecture_2 = comboBox8.Text;
                     String subject = comboBox1.Text;
                    String sub_code = textBox1.Text;

                    String tag = comboBox4.Text;
                    String room = comboBox2.Text;
                    String sub_group = comboBox3.Text;

                    String N_Of_Student = textBox2.Text;

                    String Day_and_time = comboBox6.Text;

                 
                    
                string session = comboBox7.Text;

                if (session == "normal")
                {
                    String sql = "insert into new_table(lecture_1,lecture_2, subject , sub_code , tag , room , sub_group , N_Of_Student , Day_and_time) values ('" + lecture_1 + " ','" + lecture_2 + " ','" + subject + " ','" + sub_code + " ','" + tag + "','" + room + "','" + sub_group + " ','" + N_Of_Student + "','" + Day_and_time + " ')";


                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();

                }
                else if (session == "consecutive") 
                {
                    String sql = "insert into new_table1(lecture_1,lecture_2, subject , sub_code , tag , room , sub_group , N_Of_Student , Day_and_time) values ('" + lecture_1 + " ','" + lecture_2 + " ','" + subject + " ','" + sub_code + " ','" + tag + "','" + room + "','" + sub_group + " ','" + N_Of_Student + "','" + Day_and_time + " ')";

                    MySqlCommand cmd = con.CreateCommand();
                    cmd.CommandText = sql;
                    cmd.ExecuteNonQuery();


                }



                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }



        }

       

        private void bunifuCustomDataGrid2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if(bunifuCustomDataGrid2.CurrentRow.Index != -1)
                {
                    textBox3.Text = bunifuCustomDataGrid2.CurrentRow.Cells[0].Value.ToString();
                    comboBox5.Text = bunifuCustomDataGrid2.CurrentRow.Cells[1].Value.ToString();
                    comboBox8.Text = bunifuCustomDataGrid2.CurrentRow.Cells[2].Value.ToString();
                    comboBox1.Text = bunifuCustomDataGrid2.CurrentRow.Cells[3].Value.ToString();
                    textBox1.Text = bunifuCustomDataGrid2.CurrentRow.Cells[4].Value.ToString();
                    comboBox4.Text = bunifuCustomDataGrid2.CurrentRow.Cells[5].Value.ToString();
                    comboBox2.Text = bunifuCustomDataGrid2.CurrentRow.Cells[6].Value.ToString();
                    comboBox3.Text = bunifuCustomDataGrid2.CurrentRow.Cells[7].Value.ToString();
                    textBox2.Text = bunifuCustomDataGrid2.CurrentRow.Cells[8].Value.ToString();
                    comboBox6.Text = bunifuCustomDataGrid2.CurrentRow.Cells[9].Value.ToString();
                }

            }
            catch
            {

            }
        }

        //clear data

        private void bunifuThinButton24_Click(object sender, EventArgs e)
        {
            comboBox5.Text = string.Empty;
            comboBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            comboBox4.Text = string.Empty;
            comboBox2.Text = string.Empty;
            comboBox3.Text = string.Empty;
            textBox2.Text = string.Empty;
            comboBox6.Text = string.Empty;
            textBox3.Text = string.Empty;
            comboBox8.Text = string.Empty;


        }

        private void bunifuCustomDataGrid3_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (bunifuCustomDataGrid3.CurrentRow.Index != -1)
                {
                    textBox3.Text = bunifuCustomDataGrid3.CurrentRow.Cells[0].Value.ToString();
                    comboBox5.Text = bunifuCustomDataGrid3.CurrentRow.Cells[1].Value.ToString();
                    comboBox8.Text = bunifuCustomDataGrid3.CurrentRow.Cells[2].Value.ToString();
                    comboBox1.Text = bunifuCustomDataGrid3.CurrentRow.Cells[3].Value.ToString();
                    textBox1.Text = bunifuCustomDataGrid3.CurrentRow.Cells[4].Value.ToString();
                    comboBox4.Text = bunifuCustomDataGrid3.CurrentRow.Cells[5].Value.ToString();
                    comboBox2.Text = bunifuCustomDataGrid3.CurrentRow.Cells[6].Value.ToString();
                    comboBox3.Text = bunifuCustomDataGrid3.CurrentRow.Cells[7].Value.ToString();
                    textBox2.Text = bunifuCustomDataGrid3.CurrentRow.Cells[8].Value.ToString();
                    comboBox6.Text = bunifuCustomDataGrid3.CurrentRow.Cells[9].Value.ToString();
                    
                }
                



            }
            catch
            {

            }

        }

        private void bunifuThinButton29_Click(object sender, EventArgs e)
        {
            new_table2_update();
         

            try
            {
                String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = studentdb ";
                MySqlConnection con = new MySqlConnection(connectionString);
                con.Open();
               // MessageBox.Show("connectionsuccess full!");



                String id = textBox3.Text;
                String lecture_1 = comboBox5.Text;
                String lecture_2 = comboBox8.Text;
                String subject = comboBox1.Text;
                String sub_code = textBox1.Text;

                String tag = comboBox4.Text;
                String room = comboBox2.Text;
                String sub_group = comboBox3.Text;

                String N_Of_Student = textBox2.Text;

                String Day_and_time = comboBox6.Text;

                String sql = "update new_table set lecture_1 = ' " + lecture_1 + " ' ,lecture_2 = ' " + lecture_2 + " ' , subject = ' " + subject + " ', sub_code = ' " + sub_code + " ', tag = ' " + tag + " ', room = ' " + room + " ', sub_group = ' " + sub_group + " ', N_Of_Student = ' " + N_Of_Student + " ', Day_and_time= ' " + Day_and_time + " '  where id =' " + id + " ' ";

                MySqlCommand cmd = con.CreateCommand();
                cmd.CommandText = sql;
                cmd.ExecuteNonQuery();




            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

            


        }



        //add more lecture

        public void add_lecture_con()

        {

           

        }

        public void new_table2_update()

        {
            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = studentdb ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
            // MessageBox.Show("connectionsuccess full!");



            String id = textBox3.Text;
            String lecture_1 = comboBox5.Text;
            String lecture_2 = comboBox8.Text;
            String subject = comboBox1.Text;
            String sub_code = textBox1.Text;

            String tag = comboBox4.Text;
            String room = comboBox2.Text;
            String sub_group = comboBox3.Text;

            String N_Of_Student = textBox2.Text;

            String Day_and_time = comboBox6.Text;

            String sql = "update new_table1 set lecture_1 = ' " + lecture_1 + " ' ,lecture_2 = ' " + lecture_2 + " ' , subject = ' " + subject + " ', sub_code = ' " + sub_code + " ', tag = ' " + tag + " ', room = ' " + room + " ', sub_group = ' " + sub_group + " ', N_Of_Student = ' " + N_Of_Student + " ', Day_and_time= ' " + Day_and_time + " '  where id =' " + id + " ' ";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();




        }
        public void new_table_delete()
        {
            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = studentdb ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
          

            String id = textBox3.Text;

            String sql = "delete from new_table  where id =' " + id + " ' ";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        public void new_table1_delete()
        {
            String connectionString = "server=127.0.0.1;Uid = root;pwd = root;database = studentdb ";
            MySqlConnection con = new MySqlConnection(connectionString);
            con.Open();
         

            String id = textBox3.Text;

            String sql = "delete from new_table1  where id =' " + id + " ' ";

            MySqlCommand cmd = con.CreateCommand();
            cmd.CommandText = sql;
            cmd.ExecuteNonQuery();
        }

        private void bunifuThinButton22_Click(object sender, EventArgs e)
        {
            new_table1_delete();
            new_table_delete();
            loadNtable();
            loadNtable_con();
        }

        private void bunifuThinButton28_Click(object sender, EventArgs e)
        {
            loadNtable();
            loadNtable_con();
        }

        private void bunifuCustomDataGrid1_DoubleClick(object sender, EventArgs e)
        {
           

            //consigative
            con2.connection();
            adapter2 = new MySqlDataAdapter("select lecture_1,lecture_2 from new_table1 where id like'%" + textBox3.Text + "%'",con2.con2);
            dt2 = new DataTable();
            adapter2.Fill(dt2);
            bunifuCustomDataGrid1.DataSource = dt2;
            con2.con2.Close();


            con2.connection();
            adapter2 = new MySqlDataAdapter("select lecture_1,lecture_2 from new_table where id like'%" + textBox3.Text + "%'", con2.con2);
            dt2= new DataTable();
            adapter2.Fill(dt2);
            bunifuCustomDataGrid1.DataSource = dt2;
            con2.con2.Close();

        
        }

        private void bunifuCustomDataGrid1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuCustomDataGrid4_DoubleClick(object sender, EventArgs e)
        {
            con2.connection();
            adapter2 = new MySqlDataAdapter("select lecture_1,lecture_2 from new_table1 where id like'%" + textBox3.Text + "%'", con2.con2);
            dt2 = new DataTable();
            adapter2.Fill(dt2);
            bunifuCustomDataGrid4.DataSource = dt2;
            con2.con2.Close();
        }
    }
}
