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
    public partial class Subjects : Form
    {

        connect2 con2 = new connect2();//call class connect
        MySqlCommand cmd2;
        MySqlDataReader reader2;
        MySqlDataAdapter adapter2;
        DataTable dt2;
        DataSet ds2;


        public Subjects()
        {
            InitializeComponent();
        }

        public void table_load()
        {
            guna2DataGridView1.DataSource = null;
            con2.connection();
            adapter2 = new MySqlDataAdapter("Select offeredYear'offeredYear',offeredSemester'offeredSemester',subjectName'subjectName',subjectCode'subjectCode',noOfLecHours'noOfLecHours',noOfTutHours'noOfTutHours',noOfLabHours'noOfLabHours',noOfLabHours'noOfEvoHours' from subject ", con2.con2);
            dt2 = new DataTable();
            adapter2.Fill(dt2);
            guna2DataGridView1.DataSource = dt2;
            con2.con2.Close();


        }
  
      
   



        private void btnMenu_Click(object sender, EventArgs e)
        {
            //expand
            if (sidemenu.Width == 45)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 208;
                btnAnimator.ShowSync(sidemenu);
                logoAnimator.ShowSync(sidemenu);

            }
            //minimise
            else
            {
                logoAnimator.Hide(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 45;
                btnAnimator.ShowSync(sidemenu);

            }
        }

        private void btnMenu2_Click(object sender, EventArgs e)

        {
            //expand
            if (sidemenu.Width == 45)
            {
                sidemenu.Visible = false;
                sidemenu.Width = 208;
                btnAnimator.ShowSync(sidemenu);
                logoAnimator.ShowSync(logo);

            }
            //minimize
            else
            {
                logoAnimator.HideSync(logo);
                sidemenu.Visible = false;
                sidemenu.Width = 45;
                btnAnimator.ShowSync(sidemenu);

            }
        }

       


        //save
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
              if (cmbOfferedyear.Text == "" || cmbOfferedSemester.Text == "" || txtSubjectName.Text == "" || txtSubjectCode.Text == "" || udNoLecHrs.Text == "" || udNoTuteHrs.Text == "" || udNoLabHrs.Text == "" || udNoEvoHrs.Text == "")
                {
                     MessageBox.Show("No Data Selected", "Subject Management", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                 }
                else
                  {                                                     
            con2.datasend("insert into subject (`offeredYear`,`offeredSemester`, `subjectName`, `subjectCode`, `noOfLecHours`, `noOfTutHours`, `noOfLabHours`, `noOfEvoHours`) Value('" + cmbOfferedyear.Text + "','" + cmbOfferedSemester.Text + "','" + txtSubjectName.Text + "', '" + txtSubjectCode.Text + "', '" + udNoLecHrs.Text + "','" + udNoTuteHrs.Text + "','" + udNoLabHrs.Text + "','" + udNoEvoHrs.Text + "')");
                cmbOfferedyear.Text = "";
                cmbOfferedSemester.Text = "";
                txtSubjectName.Text = "";
                txtSubjectCode.Text = "";
                udNoLecHrs.Text = null;
                udNoTuteHrs.Text = null;
                udNoLabHrs.Text = null;
                udNoEvoHrs.Text = null;

                MessageBox.Show("Successfully Data Added", "Subject Management", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void Subjects_Load(object sender, EventArgs e)
        {
            table_load();
        }
        //search
        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {
            con2.connection();
            cmd2 = new MySqlCommand("Select * from subject_table where subjectCode= '" + txtSubjectCode.Text + "'", con2.con2);
            reader2 = cmd2.ExecuteReader();

            if (reader2.Read())
            {
                cmbOfferedyear.Text = reader2.GetString("offeredYear");
                cmbOfferedSemester.Text = reader2.GetString("offeredSemester");
                txtSubjectName.Text = reader2.GetString("subjectName");
                txtSubjectCode.Text = reader2.GetString("subjectCode");
                udNoLecHrs.Text = reader2.GetString("noOfLecHours");
                udNoTuteHrs.Text = reader2.GetString("noOfTutHours");
                udNoLabHrs.Text = reader2.GetString("noOfLabHours");
                udNoEvoHrs.Text = reader2.GetString("noOfEvoHours");
            }

            else
            {
                cmbOfferedyear.Text = "";
                cmbOfferedSemester.Text = "";
                txtSubjectName.Text = "";
                txtSubjectCode.Text = "";
                udNoLecHrs.Text = null;
                udNoTuteHrs.Text = null;
                udNoLabHrs.Text = null;
                udNoEvoHrs.Text = null;
            }
        }

        //delete
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            con2.datadelete("delete from  subject where subjectCode= '" + txtSubjectCode.Text + "'");
            cmbOfferedyear.Text = "";
            cmbOfferedSemester.Text = "";
            txtSubjectName.Text = "";
            txtSubjectCode.Text = "";
            udNoLecHrs.Text = null;
            udNoTuteHrs.Text = null;
            udNoLabHrs.Text = null;
            udNoEvoHrs.Text = null;
            MessageBox.Show("Successfully Deleted", "Subject Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //update
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            con2.dataupdate("update subject set offeredYear= '" + cmbOfferedyear.Text + "',offeredSemester='" + cmbOfferedSemester.Text + "',subjectName='" + txtSubjectName.Text + "',subjectCode='" + txtSubjectCode.Text + "',noOfLecHours ='" + udNoLecHrs.Text + "',noOfTutHours='" + udNoTuteHrs.Text + "',noOfLabHours='" + udNoLabHrs.Text + "',noOfEvoHours='" + udNoEvoHrs.Text + "' where subjectCode='" + txtSubjectCode.Text + "'");
            cmbOfferedyear.Text = "";
            cmbOfferedSemester.Text = "";
            txtSubjectName.Text = null;
            txtSubjectCode.Text = null;
            udNoLecHrs.Text = null;
            udNoTuteHrs.Text = null;
            udNoLabHrs.Text = null;
            udNoEvoHrs.Text = null;
            MessageBox.Show("Successfully Updated", "Lecturer Management", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //clear
        private void guna2GradientButton4_Click(object sender, EventArgs e)
        {
            cmbOfferedyear.Text = "";
            cmbOfferedSemester.Text = "";
            txtSubjectName.Text = null;
            txtSubjectCode.Text = null;
            udNoLecHrs.Text = null;
            udNoTuteHrs.Text = null;
            udNoLabHrs.Text = null;
            udNoEvoHrs.Text = null;
        }


        //cell click
        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgvSubject.Rows[e.RowIndex];
                cmbOfferedyear.Text = row.Cells[0].Value.ToString();
                cmbOfferedSemester.Text = row.Cells[1].Value.ToString();
                txtSubjectName.Text = row.Cells[2].Value.ToString();
                txtSubjectCode.Text = row.Cells[3].Value.ToString();
                udNoLecHrs.Text = row.Cells[4].Value.ToString();
                udNoTuteHrs.Text = row.Cells[5].Value.ToString();
                udNoLabHrs.Text = row.Cells[6].Value.ToString();
                udNoEvoHrs.Text = row.Cells[7].Value.ToString();
            }
        }
    }
}
