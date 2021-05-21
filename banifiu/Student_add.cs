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
    public partial class Student_add : Form
    {

        connect con = new connect();//call class connect

        MySqlCommand cmd;
        MySqlDataReader reader;
        MySqlDataAdapter adapter;
        DataTable dt;

        public Student_add()
        {
            InitializeComponent();
        }

        private void Student_add_Load(object sender, EventArgs e)
        {
            loaduser();

            guna2GradientButton7.Enabled = false;
            guna2GradientButton6.Enabled = false; 
        }


        public void loaduser()
        {
            dataStu.DataSource = null;
            con.connection();
            adapter = new MySqlDataAdapter("select studentID'Student ID', academicYear'Academic year and semester', programme'Programme', groupNo'Group no', subgroupNo'Subgroup no' from studentadd", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataStu.DataSource = dt;
            con.con.Close();
        }
        public void loadsearch()
        {
            dataStu.DataSource = null;
            con.connection();
            adapter = new MySqlDataAdapter("select studentID'Student ID', academicYear'Academic year and semester', programme'Programme', groupNo'Group no', subgroupNo'Subgroup no' from studentadd where studentID like'%" + guna2TextBox1.Text
                + "%' or academicYear like'%" + guna2TextBox1.Text
                + "%' or programme like'%" + guna2TextBox1.Text
                + "%' or groupNo like'%" + guna2TextBox1.Text
                + "%' or subgroupNo like'%" + guna2TextBox1.Text
                + "%'", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataStu.DataSource = dt;
            con.con.Close();

        }





        private void txtStuID_TextChanged(object sender, EventArgs e)
        {
            con.connection();
            cmd = new MySqlCommand("select * from studentadd where studentID='" + txtStuID.Text + "%'", con.con);
            reader = cmd.ExecuteReader();
            if (reader.Read())
            {
                cmbAca.Text = reader.GetString("academicYear");
                cmbPrg.Text = reader.GetString("programme");
                cmbGrp.Text = reader.GetString("groupNo");
                cmbSubgrp.Text = reader.GetString("subgroupNo");
                guna2GradientButton1.Enabled = true;
                guna2GradientButton2.Enabled = true;

            }
            else
            {
                //txtStuID.Clear();
                cmbAca.ResetText();
                cmbPrg.ResetText();
                cmbGrp.ResetText();
                cmbSubgrp.ResetText();
                guna2GradientButton1.Enabled = false;
                guna2GradientButton2.Enabled = false;
            }
        }




        private void txtSearch_DoubleClick(object sender, EventArgs e)
        {
            loadsearch();
        }

        private void txtSearch_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tipid = new ToolTip();
            tipid.ShowAlways = true;
            tipid.SetToolTip(guna2TextBox1, "Search Tag using Student ID");
        }

        private void txtStuID_MouseEnter(object sender, EventArgs e)
        {
            ToolTip tipid = new ToolTip();
            tipid.ShowAlways = true;
            tipid.SetToolTip(txtStuID, "Enter a student ID. E.g.:1");
        }








        //update
        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            con.dataupdate("Update studentadd set academicYear='" + cmbAca.Text + "',programme='" + cmbPrg.Text + "',groupNo='" + cmbGrp.Text + "',subgroupNo='" + cmbSubgrp.Text + "'where studentID='" + txtStuID.Text + "'");
            txtStuID.Clear();
            cmbAca.ResetText();
            cmbPrg.ResetText();
            cmbGrp.ResetText();
            cmbSubgrp.ResetText();

            guna2GradientButton1.Enabled = false;
            guna2GradientButton2.Enabled = false;

            loaduser();
            MessageBox.Show("updated!", "Tag Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        //clear
        private void guna2GradientButton3_Click(object sender, EventArgs e)
        {
            txtStuID.Clear();
            cmbAca.ResetText();
            cmbPrg.ResetText();
            cmbGrp.ResetText();
            cmbSubgrp.ResetText();
            btnSave.Enabled = true;
        }


        //save
        private void btnSave_Click(object sender, EventArgs e)
        {

            if (cmbAca.Text == "" || cmbPrg.Text == "" || cmbGrp.Text == "" || cmbSubgrp.Text == "")
            {
                MessageBox.Show("error!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else
            {
                con.datasend("insert into studentadd(studentID,academicYear,programme,groupNo,subgroupNo) values('" + txtStuID.Text + "','" + cmbAca.Text + "','" + cmbPrg.Text + "','" + cmbGrp.Text + "','" + cmbSubgrp.Text + "')");

                cmbPrg.ResetText();

                loaduser();
                MessageBox.Show("Now click generate group ID!", "studentdb");
                guna2GradientButton7.Enabled = true;
                guna2GradientButton6.Enabled = true;

            }
        }


        //delete
        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            con.datadelete("delete from studentadd where studentID='" + txtStuID.Text + "'");
            txtStuID.Clear();
            cmbAca.ResetText();
            cmbPrg.ResetText();
            cmbGrp.ResetText();
            cmbSubgrp.ResetText();

            guna2GradientButton1.Enabled = false;
            guna2GradientButton2.Enabled = false;
            MessageBox.Show("deleted!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
            loaduser();
        }


        //Delete Group Id
        private void guna2GradientButton5_Click(object sender, EventArgs e)
        {
            con.dataupdate("Update studentadd set grpID = null where studentID='" + txtStuID.Text + "'");
            MessageBox.Show("Group ID deleted!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }


        //Generate sub group ID
        private void guna2GradientButton6_Click(object sender, EventArgs e)
        {
            if (cmbSubgrp.Text == "")
            {
                MessageBox.Show("Select sub group first!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else if (cmbGrp.Text == "")
            {
                MessageBox.Show("Generate group ID first!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var subgrpID = string.Concat(cmbAca.Text, ".", cmbGrp.Text, ".", cmbSubgrp.Text);
                con.dataupdate("Update studentadd set subgrpID='" + subgrpID + "'where studentID='" + txtStuID.Text + "'");
                MessageBox.Show("Subgroup ID generated!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtStuID.Clear();
                cmbAca.ResetText();

                cmbGrp.ResetText();
                cmbSubgrp.ResetText();
            }
        }



        //Generate Group iD
        private void guna2GradientButton7_Click(object sender, EventArgs e)
        {
            if (cmbGrp.Text == "")
            {
                MessageBox.Show("Select group first!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            else
            {
                var grpID = string.Concat(cmbAca.Text, ".", cmbGrp.Text);
                con.dataupdate("Update studentadd set grpID ='" + grpID + "'where studentID='" + txtStuID.Text + "'");
                MessageBox.Show("Group ID generated!Now click generate sub group ID", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //con.dataupdate("Update studentadd set academicYear='" + cmbAca.Text + "',programme='" + cmbPrg.Text + "',groupNo='" + cmbGrp.Text + "',subgroupNo='" + cmbSubgrp.Text + "'where studentID='" + txtStuID.Text + "'");
            }
        }


        //grid view click event
        private void dataStu_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dataStu.CurrentRow.Index != -1)
            {
                cmbAca.Text = dataStu.CurrentRow.Cells[1].Value.ToString();
                cmbPrg.Text = dataStu.CurrentRow.Cells[2].Value.ToString();
                cmbGrp.Text = dataStu.CurrentRow.Cells[3].Value.ToString();
                cmbSubgrp.Text = dataStu.CurrentRow.Cells[4].Value.ToString();
                txtStuID.Text = dataStu.CurrentRow.Cells[0].Value.ToString();
            }
            btnSave.Enabled = false;
        }


        //Delete SGroup Id
        private void guna2GradientButton8_Click(object sender, EventArgs e)
        {
            con.dataupdate("Update studentadd set subgrpID = null where studentID='" + txtStuID.Text + "'");
            MessageBox.Show("Subgroup ID deleted!", "Student Add", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
