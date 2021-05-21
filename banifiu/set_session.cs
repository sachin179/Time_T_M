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
    public partial class set_session : Form
    {
        connect con = new connect();
        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;

        public set_session()
        {
            InitializeComponent();
        }

        private void set_session_Load(object sender, EventArgs e)
        {
            load_Lec();
            load_Lec2();
            loadgrpID1();
            Subject_load1();
            Tag_load1();
            loadNtable1();
        }


        public void Subject_load1()
        {

            con.connection();
            //  MessageBox.Show("connectionsuccess full!");
            cmd = new MySqlCommand("select * from subject", con.con);
            adapter = new MySqlDataAdapter(cmd);

            ds = new DataSet();
            adapter.Fill(ds);
            //dataSession.DataSource = ds;
            con.con.Close();

            cmbSelectedSubject.DataSource = ds.Tables[0];
            cmbSelectedSubject.DisplayMember = "subjectName";
            cmbSelectedSubject.ValueMember = "id";


        }



        public void Tag_load1()
        {

            //    {
            con.connection();
            //  MessageBox.Show("connectionsuccess full!");
            cmd = new MySqlCommand("select * from tagadd", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            //dataSession.DataSource = ds;
            con.con.Close();

            cmbSelectTag.DataSource = ds.Tables[0];
            cmbSelectTag.DisplayMember = "tagName";
            cmbSelectTag.ValueMember = "tagID";


        }


        public void loadgrpID1()
        {

            con.connection();
            // MessageBox.Show("connectionsuccess full!");
            cmd = new MySqlCommand("select * from locationt", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            //dataSession.DataSource = ds;
            con.con.Close();

            cmbSelectedGroup.DataSource = ds.Tables[0];
            cmbSelectedGroup.DisplayMember = "rname";
            cmbSelectedGroup.ValueMember = "id";


        }




        public void load_Lec()

        {
            con.connection();
            //   MessageBox.Show("connectionsuccess full!");
            cmd = new MySqlCommand("select * from lecturer", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            //dataSession.DataSource = ds;
            con.con.Close();

            cmbSelectLecturer1.DataSource = ds.Tables[0];
            cmbSelectLecturer1.DisplayMember = "lecturerName";
            cmbSelectLecturer1.ValueMember = "id";

        }

        public void load_Lec2()

        {
            con.connection();
            //   MessageBox.Show("connectionsuccess full!");
            cmd = new MySqlCommand("select * from lecturer", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            //dataSession.DataSource = ds;
            con.con.Close();

            cmbSelectLecturer2.DataSource = ds.Tables[0];
            cmbSelectLecturer2.DisplayMember = "lecturerName";
            cmbSelectLecturer2.ValueMember = "id";

        }

    

 
        private void SessionManagement_Load(object sender, EventArgs e)
        {
            dgvSession.DataSource = null;
            con.connection();
            adapter = new MySqlDataAdapter("Select SessionID'SessionID', Lecturer1'Lecturer1',Lecturer2'Lecturer2',SubjectCode'SubjectCode',GroupID'GroupID',Tag'Tag',NoOfStudent'NoOfStudent',Duration'Duration' from session_table ", con.con);
            dt = new DataTable();
            ds = new DataSet();
            adapter.Fill(dt);
            dgvSession.DataSource = dt;
            con.con.Close();
            cmbSelectLecturer1.DataSource = ds.Tables[0];//from lecturer table lecturer name
             cmbSelectLecturer2.DataSource = ds.Tables[0];//''
             cmbSelectedSubject.DataSource = ds.Tables[1];//from subject table


        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            con.connection();
            cmd = new MySqlCommand("Select * from session_table where SessionID= '" + txtSessionID.Text + "'", con.con);
            reader = cmd.ExecuteReader();

            if (reader.Read())
            {
                txtSessionID.Text = reader.GetString("SessionID");
                cmbSelectLecturer1.Text = reader.GetString("Lecturer1");
                cmbSelectLecturer2.Text = reader.GetString("Lecturer2");
                cmbSelectTag.Text = reader.GetString("SubjectCode");
                cmbSelectedGroup.Text = reader.GetString("GroupID");
                cmbSelectedSubject.Text = reader.GetString("Tag");
                txtNoOfStudent.Text = reader.GetString("NoOfStudent");
                txtDuration.Text = reader.GetString("Duration");
            }
            else
            {
                txtSessionID.Text = "";
                cmbSelectLecturer1.Text = "";
                cmbSelectLecturer2.Text = "";
                cmbSelectTag.Text = "";
                cmbSelectedGroup.Text = "";
                cmbSelectedSubject.Text = "";
                txtNoOfStudent.Text = "";
                txtDuration.Text = "";
            }
        }


        public void loadNtable1()
        {




            dgvSession.DataSource = null;
            con.connection();
            // adapter = new MySqlDataAdapter("select studentID'Student ID', academicYear'Academic year and semester', programme'Programme', groupNo'Group no', subgroupNo'Subgroup no' from studentadd", con.con);
            adapter = new MySqlDataAdapter("select id,SessionID,Lecturer1,Lecturer2,SubjectCode,SubjectCode,GroupID,Tag,NoOfStudent,Duration from session_table", con.con);
         
            dt = new DataTable();
            adapter.Fill(dt);
            dgvSession.DataSource = dt;
            con.con.Close();
        }

        private void dgvSession_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSession.Rows[e.RowIndex];
                txtSessionID.Text = row.Cells[0].Value.ToString();
                cmbSelectLecturer1.Text = row.Cells[1].Value.ToString();
                cmbSelectLecturer2.Text = row.Cells[2].Value.ToString();
                cmbSelectTag.Text = row.Cells[5].Value.ToString();
                cmbSelectedGroup.Text = row.Cells[4].Value.ToString();
                cmbSelectedSubject.Text = row.Cells[3].Value.ToString();
                txtNoOfStudent.Text = row.Cells[6].Value.ToString();
                txtDuration.Text = row.Cells[7].Value.ToString();
            }
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            con.dataupdate("update session_table set SessionID='" + txtSessionID.Text + "', Lecturer1= '" + cmbSelectLecturer1.Text + "',Lecturer2='" + cmbSelectLecturer2.Text + "',SubjectCode='" + cmbSelectedSubject.Text + "',GroupID='" + cmbSelectedGroup.Text + "',Tag ='" + cmbSelectTag.Text + "',NoOfStudent='" + txtNoOfStudent.Text + "', Duration='" + txtDuration.Text + "' where   SessionID='" + txtSessionID.Text + "'");
            txtSessionID.Text = "";
            cmbSelectLecturer1.Text = "";
            cmbSelectLecturer2.Text = "";
            cmbSelectTag.Text = "";
            cmbSelectedGroup.Text = "";
            cmbSelectedSubject.Text = "";
            txtNoOfStudent.Text = "";
            txtDuration.Text = "";
            MessageBox.Show("Successfully Updated", "Session Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Deletebtn_Click(object sender, EventArgs e)
        {
            con.datadelete("delete from  session_table where  SessionID='" + txtSessionID.Text + "'");
            txtSessionID.Text = "";
            cmbSelectLecturer1.Text = "";
            cmbSelectLecturer2.Text = "";
            cmbSelectTag.Text = "";
            cmbSelectedGroup.Text = "";
            cmbSelectedSubject.Text = "";
            txtNoOfStudent.Text = "";
            txtDuration.Text = "";
            MessageBox.Show("Successfully Deleted", "Session Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void Clearbtn_Click(object sender, EventArgs e)
        {
            txtSessionID.Text = "";
            cmbSelectLecturer1.Text = "";
            cmbSelectLecturer2.Text = "";
            cmbSelectTag.Text = "";
            cmbSelectedGroup.Text = "";
            cmbSelectedSubject.Text = "";
            txtNoOfStudent.Text = "";
            txtDuration.Text = "";
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            if (txtSessionID.Text == "" || cmbSelectLecturer1.Text == "" || cmbSelectLecturer2.Text == "" || cmbSelectTag.Text == "" || cmbSelectedGroup.Text == "" || cmbSelectedSubject.Text == "" || txtNoOfStudent.Text == "" || txtDuration.Text == "")

            {
                MessageBox.Show("No Data Selected", "Session Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else

            {
                con.datasend("insert into session_table (`SessionID`,`Lecturer1`,`Lecturer2`, `SubjectCode`, `GroupID`, `Tag`, `NoOfStudent`, `Duration`) Value('" + txtSessionID.Text + "','" + cmbSelectLecturer1.Text + "','" + cmbSelectLecturer2.Text + "','" + cmbSelectedSubject.Text + "', '" + cmbSelectedGroup.Text + "', '" + cmbSelectTag.Text + "','" + txtNoOfStudent.Text + "','" + txtDuration.Text + "')");
                txtSessionID.Text = "";
                cmbSelectLecturer1.Text = "";
                cmbSelectLecturer2.Text = "";
                cmbSelectTag.Text = "";
                cmbSelectedGroup.Text = "";
                cmbSelectedSubject.Text = "";
                txtNoOfStudent.Text = "";
                txtDuration.Text = "";

                MessageBox.Show("Successfully Data Added", "Session Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }
    }
}
