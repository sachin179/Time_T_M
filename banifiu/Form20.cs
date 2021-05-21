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
            cmd2 = new MySqlCommand("select * from workday2", con2.con2);
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




            bunifuCustomDataGrid2.DataSource = null;
            con.connection();
            // adapter = new MySqlDataAdapter("select studentID'Student ID', academicYear'Academic year and semester', programme'Programme', groupNo'Group no', subgroupNo'Subgroup no' from studentadd", con.con);
            adapter = new MySqlDataAdapter("select id,lecture_1,lecture_2,subject,sub_code,tag,room,sub_group,N_Of_Student,Day_and_time from new_table", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            bunifuCustomDataGrid2.DataSource = dt;
            con.con.Close();
        }





        public void loadNtable_con()
        {


        

            bunifuCustomDataGrid3.DataSource = null;
            con.connection();
            // adapter = new MySqlDataAdapter("select studentID'Student ID', academicYear'Academic year and semester', programme'Programme', groupNo'Group no', subgroupNo'Subgroup no' from studentadd", con.con);
            adapter = new MySqlDataAdapter("select id,lecture_1,lecture_2,subject,sub_code,tag,room,sub_group,N_Of_Student,Day_and_time from new_table1", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            bunifuCustomDataGrid3.DataSource = dt;
            con.con.Close();
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
            else if (tname == "DS")
            {
                textBox1.Text = "IT3020";
            }
            else if (tname == "ESD")
            {
                textBox1.Text = "IT3050";
            }
            else if (tname == "ITPM")
            {
                textBox1.Text = "IT3040";
            }
            else if (tname == "MAD")
            {
                textBox1.Text = "IT2010";
            }
            else if (tname == "PAF")
            {
                textBox1.Text = "IT3030";
            }
            else if (tname == "PAF")
            {
                textBox1.Text = "IT1020";
            }

            else if (tname == "DSA")
            {
                textBox1.Text = "IT2070";
            }
            else if (tname == "PS")
            {
                textBox1.Text = "IT2110";
            }
            else if (tname == "CN")
            {
                textBox1.Text = "IT1121";
            }
            else if (tname == "OOC")
            {
                textBox1.Text = "IT2120";
            }
            else if (tname == "OSSA")
            {
                textBox1.Text = "IT1021";
            }
            //cmbTrel.Enabled = false;
        }

  

        private void bunifuCustomDataGrid2_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                if (bunifuCustomDataGrid2.CurrentRow.Index != -1)
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
           
          
           textBox1.Text = string.Empty;
            textBox2.Text = string.Empty; 
            textBox3.Text = string.Empty;
            comboBox2.SelectedIndex = -1;
            comboBox5.SelectedIndex = -1;
            comboBox1.SelectedIndex = -1;
            comboBox4.SelectedIndex = -1;
            comboBox3.SelectedIndex = -1;
           
            comboBox8.SelectedIndex = -1;
            comboBox6.Text = string.Empty;


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
    
                con.dataupdate("Update new_table set lecture_1='" + comboBox5.Text + "',lecture_2='" + comboBox8.Text + "',subject='" + comboBox1.Text + "',sub_code='" + textBox1.Text + "',tag='" + comboBox4.Text + "',room='" + comboBox2.Text + "',sub_group='" + comboBox3.Text + "',N_Of_Student='" + textBox2.Text + "',Day_and_time='" + comboBox6.Text + "'where id='" + textBox3.Text + "'");

                //  con.dataupdate("Update studentadd set lecture_1='" + comboBox5.Text + "',lecture_2 ='" + comboBox8.Text + "',subject='" + comboBox1.Text + "'subject='" + comboBox1.Text + "',sub_code='" + textBox1.Text + "'where studentID='" + txtStuID.Text + "'");,groupNo='" + cmbGrp.Text + "'
                MessageBox.Show("Updated!", "Update Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }




        }




        //update
        public void new_table2_update()

        {
         
            con.dataupdate("Update new_table1 set lecture_1='" + comboBox5.Text + "',lecture_2='" + comboBox8.Text + "',subject='" + comboBox1.Text + "',sub_code='" + textBox1.Text + "',tag='" + comboBox4.Text + "',room='" + comboBox2.Text + "',sub_group='" + comboBox3.Text + "',N_Of_Student='" + textBox2.Text + "',Day_and_time='" + comboBox6.Text + "'where id='" + textBox3.Text + "'");
           
        }

        //delete
        public void new_table_delete()
        {
          
            con.datadelete("delete from new_table where id='" + textBox3.Text + "'");
        }


        //delete data
        public void new_table1_delete()
        {
   
            con.datadelete("delete from new_table1 where id='" + textBox3.Text + "'");
            MessageBox.Show("deleted!", "Delete Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);
           
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



       
    
            //click event
        private void bunifuCustomDataGrid2_Click(object sender, EventArgs e)
        {
            try
            {
                if (bunifuCustomDataGrid2.CurrentRow.Index != -1)
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

     

        private void bunifuCustomDataGrid3_Click(object sender, EventArgs e)
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

        private void bunifuCustomDataGrid1_Click(object sender, EventArgs e)
        {
            con2.connection();
            adapter2 = new MySqlDataAdapter("select lecture_1,lecture_2 from new_table where id like'%" + textBox3.Text + "%'", con2.con2);
            dt2 = new DataTable();
            adapter2.Fill(dt2);
            bunifuCustomDataGrid1.DataSource = dt2;
            con2.con2.Close();
        }

        private void bunifuCustomDataGrid4_Click(object sender, EventArgs e)
        {
            con2.connection();
            adapter2 = new MySqlDataAdapter("select lecture_1,lecture_2 from new_table1 where id like'%" + textBox3.Text + "%'", con2.con2);
            dt2 = new DataTable();
            adapter2.Fill(dt2);
            bunifuCustomDataGrid4.DataSource = dt2;
            con2.con2.Close();
        }

        private void bunifuThinButton21_Click_1(object sender, EventArgs e)
        {

          

            try
            {


                string session = comboBox7.Text;

                if (session == "normal")
                {
                    if (comboBox5.Text == "" || comboBox1.Text == "" || textBox1.Text == "" || comboBox4.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                    {
                        MessageBox.Show("error!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }

                    else

                    {
                        con.datasend("insert into new_table(lecture_1,lecture_2, subject , sub_code , tag , room , sub_group , N_Of_Student , Day_and_time) values ('" + comboBox5.Text + " ','" + comboBox8.Text + " ','" + comboBox1.Text + " ','" + textBox1.Text + " ','" + comboBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + " ','" + textBox2.Text + "','" + comboBox6.Text + " ')");
                        MessageBox.Show("Inserted!", "Insert Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadNtable();
                        loadNtable_con();


                    }

                  

                }
                else if (session == "consecutive")
                {

                    if (comboBox5.Text == "" || comboBox1.Text == "" || textBox1.Text == "" || comboBox4.Text == "" || comboBox2.Text == "" || comboBox3.Text == "")
                    {
                        MessageBox.Show("error!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                        return;
                    }
                    else
                    {
                        con.datasend("insert into new_table1(lecture_1,lecture_2, subject , sub_code , tag , room , sub_group , N_Of_Student , Day_and_time) values ('" + comboBox5.Text + " ','" + comboBox8.Text + " ','" + comboBox1.Text + " ','" + textBox1.Text + " ','" + comboBox4.Text + "','" + comboBox2.Text + "','" + comboBox3.Text + " ','" + textBox2.Text + "','" + comboBox6.Text + " ')");
                        MessageBox.Show("Inserted!", "Insert Successfull", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        loadNtable();
                        loadNtable_con();
                    }

                    //  String sql = "insert into new_table1(lecture_1,lecture_2, subject , sub_code , tag , room , sub_group , N_Of_Student , Day_and_time) values ('" + lecture_1 + " ','" + lecture_2 + " ','" + subject + " ','" + sub_code + " ','" + tag + "','" + room + "','" + sub_group + " ','" + N_Of_Student + "','" + Day_and_time + " ')";
                   
                    //  MySqlCommand cmd = con.CreateCommand();
                    // cmd.CommandText = sql;
                    // cmd.ExecuteNonQuery(); 
                   
                }

            }




            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }

}
