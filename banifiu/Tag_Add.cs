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
    public partial class Tag_Add : Form
    {
        connect con = new connect();//call class connect

        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Tag_Add()
        {
            InitializeComponent();
        }

      

        public void loaduser()
        {
            dataTag.DataSource = null;
            con.connection();
            adapter = new MySqlDataAdapter("select * from tagadd where tagID like'%" + txtTagID.Text + "%'", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataTag.DataSource = dt;
            con.con.Close();
        }
        public void loadsearch()
        {
            dataTag.DataSource = null;
            con.connection();
            adapter = new MySqlDataAdapter("select tagID'Tag ID', tagName'Tag Name', tagCode'Tag Code', tagRel'Related Tag'  from tagadd where tagID like'%" + txtSearch.Text + "%'or tagName like'%" + txtSearch.Text + "%' or tagCode like'%" + txtSearch.Text + "%' or tagRel like'%" + txtSearch.Text + "%'", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataTag.DataSource = dt;
            con.con.Close();

        }


        private void txtTagID_TextChanged(object sender, EventArgs e)
        {
            {
                con.connection();
                cmd = new MySqlCommand("select * from tagadd where tagID='" + txtTagID.Text + "'", con.con);
                reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    cmbTname.Text = reader.GetString("tagName");
                    cmbTcode.Text = reader.GetString("tagCode");
                    cmbTrel.Text = reader.GetString("tagRel");

                    guna2GradientButton1.Enabled = true;
                    guna2GradientButton2.Enabled = true;

                }
                else
                {
                    //txtStuID.Clear();
                    cmbTname.ResetText();
                    cmbTcode.ResetText();
                    cmbTrel.ResetText();

                    guna2GradientButton1.Enabled = false;
                    guna2GradientButton2.Enabled = false;
                }
            }

        }





        private void txtTagID_MouseHover(object sender, EventArgs e)
        {
            ToolTip tipt = new ToolTip();
            tipt.ShowAlways = true;
            tipt.SetToolTip(txtTagID, "Enter a tag ID. E.g.:1");
        }




        




        private void cmbTcode_Click(object sender, EventArgs e)
        {
            string tname = cmbTname.Text;

            if (tname == "Lec")
            {
                cmbTcode.SelectedText = "01";
            }
            else if (tname == "Tute")
            {
                cmbTcode.SelectedText = "02";
            }
            else if (tname == "Lab")
            {
                cmbTcode.SelectedText = "03";
            }
            cmbTcode.Enabled = false;
        }


        private void cmbTrel_Click(object sender, EventArgs e)
        {
            string tname = cmbTname.Text;

            if (tname == "Lec")
            {
                cmbTrel.SelectedText = "Lecture";
            }
            else if (tname == "Tute")
            {
                cmbTrel.SelectedText = "Tutorial";
            }
            else if (tname == "Lab")
            {
                cmbTrel.SelectedText = "Lab";
            }
            cmbTrel.Enabled = false;
        }

        private void cmbTname_SelectionChangeCommitted(object sender, EventArgs e)
        {
            cmbTcode.Enabled = true;
            cmbTrel.Enabled = true;
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tipid = new ToolTip();
            tipid.ShowAlways = true;
            tipid.SetToolTip(txtSearch, "Search Tag using Tag ID");
        }


      
        
        
        //formload

        private void Tag_Add_Load(object sender, EventArgs e)
        {
            loaduser();
        }


        //Save
        private void btnSave_Click(object sender, EventArgs e)
        {
            if (cmbTname.Text == "" || cmbTcode.Text == "" || cmbTrel.Text == "")
            {
                MessageBox.Show("error!", "Tag Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            else
            {
                con.datasend("insert into tagadd(tagID,tagName,tagCode,tagRel) values('" + txtTagID.Text + "','" + cmbTname.Text + "','" + cmbTcode.Text + "','" + cmbTrel.Text + "')");
                txtTagID.Clear();
                cmbTname.ResetText();
                cmbTcode.ResetText();
                cmbTrel.ResetText();

                MessageBox.Show("data added successfully!", "studentdb");
                loaduser();
            }
        }

        //update
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            con.dataupdate("Update tagadd set tagName='" + cmbTname.Text + "',tagCode='" + cmbTcode.Text + "',tagRel='" + cmbTrel.Text + "'where tagID='" + txtTagID.Text + "'");
            txtTagID.Clear();
            cmbTname.ResetText();
            cmbTcode.ResetText();
            cmbTrel.ResetText();

            guna2GradientButton1.Enabled = false;
            guna2GradientButton2.Enabled = false;
            MessageBox.Show("updated!", "Tag Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaduser();

        }
        ///clear
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
             txtTagID.Clear();
            cmbTcode.ResetText();
            cmbTname.ResetText();
            cmbTrel.ResetText();

            btnSave.Enabled = true;

        }

        //delete
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            con.datadelete("delete from tagadd where tagID='" + txtTagID.Text + "'");
            txtTagID.Clear();
            cmbTname.ResetText();
            cmbTcode.ResetText();
            cmbTrel.ResetText();

            guna2GradientButton1.Enabled = false;
            guna2GradientButton2.Enabled = false;
            MessageBox.Show("deleted!", "Tag Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaduser();
        }



        

        private void dataTag_Click(object sender, EventArgs e)
        {
                if (dataTag.CurrentRow.Index != -1)
                {
                    cmbTname.Text = dataTag.CurrentRow.Cells[1].Value.ToString();
                    cmbTcode.Text = dataTag.CurrentRow.Cells[2].Value.ToString();
                    cmbTrel.Text = dataTag.CurrentRow.Cells[3].Value.ToString();
                    txtTagID.Text = dataTag.CurrentRow.Cells[0].Value.ToString();
                }
                btnSave.Enabled = false;
            
        }
    }
}
