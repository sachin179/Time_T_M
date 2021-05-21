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
    public partial class Se_Not_available : Form
    {
        connect con = new connect();//call class connect

        MySqlCommand cmd;
        //MySqlDataReader reader;
        MySqlDataAdapter adapter;
        DataTable dt;
        DataSet ds;
        DataSet dataSet;
        public Se_Not_available()
        {
            InitializeComponent();
        }

        private void Se_Not_available_Load(object sender, EventArgs e)
        {
            //loadCuser();
            loadCgrpID();
            loadCsubgrpID();
            loadCsubcode();
            loadCtagname();
            dataSessionC2.Hide();

            //loadPuser();
            loadPsttime();
            loadPdur();
            loadPday();
            loadPsubcode();
            loadPprg();
            dataSessionP2.Hide();

            //loadNuser();
            loadNsttime();
            loadNdur();
            loadNday();
            loadNsubcode();
            loadNprg();
            dataSessionN2.Hide();

            //not available times
            loadLecName();
            selectGroup();
            subGroup();
            session();
            viewOnDataGrid();
        }

      
        /*************************************original TABLE of consecutive tab**************************************/
        public void loadCuser()
        {
            try
            {
                con.connection();
                adapter = new MySqlDataAdapter("select id'ID',grpID'Group ID',subgrpID'Subgroup ID',subcode'Subject code',tagName'Tag name' from session where grpID like'%" + drpdwngrpID.Text + "%'" + "and subgrpID like'%" + drpdwnsubgrpID.Text + "%' " + "and subcode like'%" + drpdwnsubcode.Text + "%'", con.con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSessionC1.DataSource = dt;
                con.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Data could not be read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.con.Close();
            }
        }
        /*************************************added TABLE of consecutive tab**************************************/
        public void loadCCuser()
        {
            try
            {
                con.connection();
                adapter = new MySqlDataAdapter("select consecutiveID'Consecutive ID',grpID'Group ID',subgrpID'Subgroup ID',subcode'Subject code', tagName'Tag name' from consecutive where grpID like'%" + drpdwngrpID.Text + "%'" + "and subgrpID like'%" + drpdwnsubgrpID.Text + "%'" + "and subcode like'%" + drpdwnsubcode.Text + "%'", con.con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSessionC2.DataSource = dt;
                con.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Data could not be read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.con.Close();
            }
        }
        /* public void loadsearch()
         {
             //dataSession.DataSource = null;
             con.connection();
             adapter = new MySqlDataAdapter("select grpID'Group ID', subgrpID'Sub group ID', programme'Programme', groupNo'Group no', subgroupNo'Subgroup no' from studentadd where studentID like'%" + txtCID.Text + "%'", con.con);
             dt = new DataTable();
             adapter.Fill(dt);
             dataSession.DataSource = dt;
             con.con.Close();

         }*/

        /*************************************dropdowns of consecutive tab**************************************/
        public void loadCgrpID()
        {

            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            con.con.Close();
            drpdwngrpID.DataSource = ds.Tables[0];
            drpdwngrpID.DisplayMember = "grpID";
            drpdwngrpID.ValueMember = "id";

        }

        public void loadCsubgrpID()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            con.con.Close();
            drpdwnsubgrpID.DataSource = ds.Tables[0];
            drpdwnsubgrpID.DisplayMember = "subgrpID";
            drpdwnsubgrpID.ValueMember = "id";


        }

        public void loadCsubcode()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            con.con.Close();

            drpdwnsubcode.DataSource = ds.Tables[0];
            drpdwnsubcode.DisplayMember = "subcode";
            drpdwnsubcode.ValueMember = "id";

        }
        public void loadCtagname()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            con.con.Close();

            tagName.DataSource = ds.Tables[0];
            tagName.DisplayMember = "tagName";
            tagName.ValueMember = "id";
        }

        /*************************************original table of parallel tab**************************************/
        public void loadPuser()
        {
            try
            {

                con.connection();
                adapter = new MySqlDataAdapter("select * from session where sTime like'%" + drpdwnPsttime.Text + "%'" + "and eTime like'%" + drpdwnPdur.Text + "%'" + "and wd like'%" + drpdwnPday.Text + "%'" + "and programme like'%" + drpdwnPprg.Text + "%'", con.con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSessionP1.DataSource = dt;
                con.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Data could not be read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.con.Close();
            }
        }
        /*************************************added table of parallel tab**************************************/
        public void loadPPuser()
        {
            con.connection();
            adapter = new MySqlDataAdapter("select * from parallel where sTime like'%" + drpdwnPsttime.Text + "%'" + "and eTime like'%" + drpdwnPdur.Text + "%'" + "and wd like'%" + drpdwnPday.Text + "%'" + "and programme like'%" + drpdwnPprg.Text + "%'", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataSessionP2.DataSource = dt;
            con.con.Close();
        }
        /**************************************dropdowns of parallel tab****************************************/
        public void loadPsttime()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            con.con.Close();

            drpdwnPsttime.DataSource = ds.Tables[0];
            drpdwnPsttime.DisplayMember = "sTime";
            drpdwnPsttime.ValueMember = "id";

        }

        public void loadPdur()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            con.con.Close();

            drpdwnPdur.DataSource = ds.Tables[0];
            drpdwnPdur.DisplayMember = "eTime";
            drpdwnPdur.ValueMember = "id";

        }
        public void loadPday()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            con.con.Close();

            drpdwnPday.DataSource = ds.Tables[0];
            drpdwnPday.DisplayMember = "wd";
            drpdwnPday.ValueMember = "id";

        }
        public void loadPsubcode()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            con.con.Close();

            drpdwnPsubcode.DataSource = ds.Tables[0];
            drpdwnPsubcode.DisplayMember = "subcode";
            drpdwnPsubcode.ValueMember = "id";

        }
        public void loadPprg()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);

            con.con.Close();

            drpdwnPprg.DataSource = ds.Tables[0];
            drpdwnPprg.DisplayMember = "programme";
            drpdwnPprg.ValueMember = "id";

        }

        /*************************************original table of nonoverlapping tab**************************************/

        public void loadNuser()
        {
            try
            {

                con.connection();
                adapter = new MySqlDataAdapter("select * from session where sTime like'%" + drpdwnNsttime.Text + "%'" + "and eTime like'%" + drpdwnNdur.Text + "%'" + "and wd like'%" + drpdwnNday.Text + "%'" + "and subcode like'%" + drpdwnNsubcode.Text + "%'", con.con);
                dt = new DataTable();
                adapter.Fill(dt);
                dataSessionN1.DataSource = dt;
                con.con.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Data could not be read", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.con.Close();
            }
        }

        /*************************************added table of nonoverlapping tab**************************************/

        public void loadNNuser()
        {
            con.connection();
            adapter = new MySqlDataAdapter("select * from nonoverlapping where sTime like'%" + drpdwnNsttime.Text + "%'" + "and eTime like'%" + drpdwnNdur.Text + "%'" + "and wd like'%" + drpdwnNday.Text + "%'" + "and subcode like'%" + drpdwnNsubcode.Text + "%'", con.con);
            dt = new DataTable();
            adapter.Fill(dt);
            dataSessionN2.DataSource = dt;
            con.con.Close();
        }
        /**************************************dropdowns of nonoverlapping tab****************************************/

        public void loadNsttime()
        {
            //dataSession.DataSource = null;
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            con.con.Close();
            drpdwnNsttime.DataSource = ds.Tables[0];
            drpdwnNsttime.DisplayMember = "sTime";
            drpdwnNsttime.ValueMember = "id";

        }
        public void loadNdur()
        {
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            con.con.Close();

            drpdwnNdur.DataSource = ds.Tables[0];
            drpdwnNdur.DisplayMember = "eTime";
            drpdwnNdur.ValueMember = "id";

        }
        public void loadNday()
        {
            //dataSession.DataSource = null;
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            con.con.Close();
            drpdwnNday.DataSource = ds.Tables[0];
            drpdwnNday.DisplayMember = "wd";
            drpdwnNday.ValueMember = "id";

        }

        public void loadNsubcode()
        {
            //drpdwnN.DataSource = null;
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            con.con.Close();

            drpdwnNsubcode.DataSource = ds.Tables[0];
            drpdwnNsubcode.DisplayMember = "subcode";
            drpdwnNsubcode.ValueMember = "id";

        }
        public void loadNprg()
        {
            //dataSession.DataSource = null;
            con.connection();
            cmd = new MySqlCommand("select * from session", con.con);
            adapter = new MySqlDataAdapter(cmd);
            ds = new DataSet();
            adapter.Fill(ds);
            con.con.Close();
            drpdwnNprg.DataSource = ds.Tables[0];
            drpdwnNprg.DisplayMember = "programme";
            drpdwnNprg.ValueMember = "id";

        }





        private void btnCadd_Click(object sender, EventArgs e)
        {
           
        }

        private void btnCadd_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (drpdwngrpID.Text == "" || drpdwnsubgrpID.Text == "" || drpdwnsubcode.Text == "")
                {
                    MessageBox.Show("Enter details!", "consecutive sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (tagName.Text == "")
                {
                    MessageBox.Show("Enter tag name!", "consecutive sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    con.datasend("insert into consecutive(consecutiveID,grpID,subgrpID,subcode,tagName) values('" + txtCID.Text + "','" + drpdwngrpID.Text + "','" + drpdwnsubgrpID.Text + "','" + drpdwnsubcode.Text + "','" + tagName.Text + "')");
                    txtCID.Clear();
                    loadCCuser();
                    dataSessionC1.Hide();
                    dataSessionC2.Show();
                    MessageBox.Show("Added!", "Consecutive Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception eCadd)
            {
                MessageBox.Show(eCadd.Message, "Data could not be added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.con.Close();
            }
        }

        private void btnCdlt_Click(object sender, EventArgs e)
        {
            try
            {
                con.datadelete("delete from consecutive  where consecutiveID='" + txtCID.Text + "'");
                txtCID.Clear();
                loadCCuser();
                dataSessionC1.Hide();
                dataSessionC2.Show();
                btnCget.Enabled = true;
                MessageBox.Show("deleted!", "Consecutive Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception eNdlt)
            {
                MessageBox.Show(eNdlt.Message, "Data could not be deleted!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        /*private void dataSession_DoubleClick(object sender, EventArgs e)
        {
            
            if (dataSessionC.CurrentRow.Index != -1)
            {
                drpdwngrpID.Text = dataSessionC.CurrentRow.Cells[1].Value.ToString();
                drpdwnsubgrpID.Text = dataSessionC.CurrentRow.Cells[2].Value.ToString();
                drpdwnsubcode.Text = dataSessionC.CurrentRow.Cells[3].Value.ToString();
                tagName.Text = dataSessionC.CurrentRow.Cells[4].Value.ToString();
                txtCID.Text = dataSessionC.CurrentRow.Cells[0].Value.ToString();
            }
            btnCget.Enabled = false;
 
        }*/

        private void btnCclr_Click(object sender, EventArgs e)
        {
            txtCID.Clear();
            drpdwngrpID.ResetText();
            drpdwnsubgrpID.ResetText();
            drpdwnsubcode.ResetText();
            tagName.ResetText();
            btnCadd.Enabled = true;
        }



        /************************************get button parallel tab**********************************************/
        private void btnPget_Click(object sender, EventArgs e)
        {
           
                if (drpdwnPsttime.Text == "")
                {
                    MessageBox.Show("Select a start time!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else if (drpdwnPdur.Text == "")
                {
                    MessageBox.Show("Select an end time!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else if (drpdwnPday.Text == "")
                {
                    MessageBox.Show("Select a day!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else if (drpdwnPprg.Text == "")
                {
                    MessageBox.Show("Select a programme!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                    return;
                }
                else
                {

                    MessageBox.Show("Now select a subject code", "sessions not available times");
                    loadPuser();

                }
        }
        
        /************************************get button consecutive tab**********************************************/
        private void btnCget_Click(object sender, EventArgs e)
        {
            if (drpdwngrpID.Text == "")
            {
                MessageBox.Show("Select a group ID!", "consecutive sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (drpdwnsubgrpID.Text == "")
            {
                MessageBox.Show("Select a sub group ID!", "consecutive sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (drpdwnsubcode.Text == "")
            {
                MessageBox.Show("Select a sub group ID!", "consecutive sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }

            else
            {

                MessageBox.Show("Now select a tag", "sessions not available times");
                loadCuser();

            }
        
        }

        private void btnNadd_Click(object sender, EventArgs e)
        {
            try
            {

                if (drpdwnNsttime.Text == "" || drpdwnNdur.Text == "" || drpdwnNday.Text == "" || drpdwnNsubcode.Text == "")
                {
                    MessageBox.Show("Select details first!", "nonoverlapping sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (drpdwnNprg.Text == "")
                {
                    MessageBox.Show("Select a programme first!", "nonoverlapping sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataSessionN1.Hide();
                    dataSessionN2.Show();
                    con.datasend("insert into nonoverlapping(nonID,sTime,eTime,wd,programme,subcode) values('" + txtNID.Text + "','" + drpdwnNsttime.Text + "','" + drpdwnNdur.Text + "','" + drpdwnNday.Text + "','" + drpdwnNprg.Text + "','" + drpdwnNsubcode.Text + "')");
                    txtNID.Clear();
                    loadNNuser();
                    MessageBox.Show("Added!", "Non overlapping Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception eNadd)
            {
                MessageBox.Show(eNadd.Message, "Data could not be added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.con.Close();
            }
        }

        private void btnNdlt_Click(object sender, EventArgs e)
        {
            try
            {
                con.datadelete("delete from nonoverlapping where nonID='" + txtNID.Text + "'");
                txtNID.Clear();
                loadNNuser();
                btnNget.Enabled = true;
                MessageBox.Show("Deleted!", "Non overlapping Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception edlt)
            {
                MessageBox.Show("Data could not be deleted!", "Non overlapping Sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


      
        /*************************************************original datagridview consecutive**********************************************************/
        private void dataSessionC1_DoubleClick(object sender, EventArgs e)
        {
            if (dataSessionC1.CurrentRow.Index != -1)
            {
                drpdwngrpID.Text = dataSessionC1.CurrentRow.Cells[1].Value.ToString();
                drpdwnsubgrpID.Text = dataSessionC1.CurrentRow.Cells[2].Value.ToString();
                drpdwnsubcode.Text = dataSessionC1.CurrentRow.Cells[3].Value.ToString();
                txtCID.Text = dataSessionC1.CurrentRow.Cells[0].Value.ToString();

            }
        }

        /*************************************************added datagridview consecutive**********************************************************/
        private void dataSessionC2_DoubleClick(object sender, EventArgs e)
        {
            if (dataSessionC2.CurrentRow.Index != -1)
            {
                drpdwngrpID.Text = dataSessionC2.CurrentRow.Cells[1].Value.ToString();
                drpdwnsubgrpID.Text = dataSessionC2.CurrentRow.Cells[2].Value.ToString();
                drpdwnsubcode.Text = dataSessionC2.CurrentRow.Cells[3].Value.ToString();
                tagName.Text = dataSessionC2.CurrentRow.Cells[4].Value.ToString();
                txtCID.Text = dataSessionC2.CurrentRow.Cells[0].Value.ToString();

            }
        }
        /*************************************************original datagridview parallel**********************************************************/
        private void dataSessionP1_DoubleClick(object sender, EventArgs e)
        {
            if (dataSessionP1.CurrentRow.Index != -1)
            {
                drpdwnPsttime.Text = dataSessionP1.CurrentRow.Cells[6].Value.ToString();
                drpdwnPdur.Text = dataSessionP1.CurrentRow.Cells[7].Value.ToString();
                drpdwnPday.Text = dataSessionP1.CurrentRow.Cells[8].Value.ToString();
                drpdwnPsubcode.Text = dataSessionP1.CurrentRow.Cells[4].Value.ToString();
                drpdwnPprg.Text = dataSessionP1.CurrentRow.Cells[3].Value.ToString();
                txtPID.Text = dataSessionP1.CurrentRow.Cells[0].Value.ToString();

            }
        }

        /*************************************************added datagridview parallel**********************************************************/
        private void dataSessionP2_DoubleClick(object sender, EventArgs e)
        {
            if (dataSessionP2.CurrentRow.Index != -1)
            {
                drpdwnPsttime.Text = dataSessionP2.CurrentRow.Cells[1].Value.ToString();
                drpdwnPdur.Text = dataSessionP2.CurrentRow.Cells[2].Value.ToString();
                drpdwnPday.Text = dataSessionP2.CurrentRow.Cells[3].Value.ToString();
                drpdwnPsubcode.Text = dataSessionP2.CurrentRow.Cells[4].Value.ToString();
                drpdwnPprg.Text = dataSessionP2.CurrentRow.Cells[5].Value.ToString();
                txtPID.Text = dataSessionP2.CurrentRow.Cells[0].Value.ToString();

            }
        }
        /*************************************************original datagridview nonoverlapping**********************************************************/
        private void dataSessionN1_DoubleClick(object sender, EventArgs e)
        {
            
                if (dataSessionN1.CurrentRow.Index != -1)
                {
                    drpdwnNsttime.Text = dataSessionN1.CurrentRow.Cells[6].Value.ToString();
                    drpdwnNdur.Text = dataSessionN1.CurrentRow.Cells[7].Value.ToString();
                    drpdwnNday.Text = dataSessionN1.CurrentRow.Cells[8].Value.ToString();
                    drpdwnNsubcode.Text = dataSessionN1.CurrentRow.Cells[4].Value.ToString();
                    drpdwnNprg.Text = dataSessionN1.CurrentRow.Cells[3].Value.ToString();
                    txtNID.Text = dataSessionN1.CurrentRow.Cells[0].Value.ToString();

                }
            }
        /*************************************************added datagridview nonoverlapping**********************************************************/
        private void dataSessionN2_DoubleClick(object sender, EventArgs e)
        {
            if (dataSessionN2.CurrentRow.Index != -1)
            {
                drpdwnNsttime.Text = dataSessionN2.CurrentRow.Cells[1].Value.ToString();
                drpdwnNdur.Text = dataSessionN2.CurrentRow.Cells[2].Value.ToString();
                drpdwnNday.Text = dataSessionN2.CurrentRow.Cells[3].Value.ToString();
                drpdwnNsubcode.Text = dataSessionN2.CurrentRow.Cells[4].Value.ToString();
                drpdwnNprg.Text = dataSessionN2.CurrentRow.Cells[5].Value.ToString();
                txtNID.Text = dataSessionN2.CurrentRow.Cells[0].Value.ToString();

            }
        }




        private void btnPclr_Click(object sender, EventArgs e)
        {
            txtPID.Clear();
            drpdwnPsttime.ResetText();
            drpdwnPdur.ResetText();
            drpdwnPday.ResetText();
            drpdwnPprg.ResetText();
            drpdwnPsubcode.ResetText();
            btnPadd.Enabled = true;
        }


        private void btnNclr_Click(object sender, EventArgs e)
        {
            txtNID.Clear();
            drpdwnNsttime.ResetText();
            drpdwnNdur.ResetText();
            drpdwnNday.ResetText();
            drpdwnNprg.ResetText();
            drpdwnNsubcode.ResetText();
            btnNadd.Enabled = true;
        }

        private void btnPdlt_Click(object sender, EventArgs e)
        {
            try
            {

                con.datadelete("delete from parallel where parallelID='" + txtPID.Text + "'");
                txtPID.Clear();
                loadPPuser();
                btnPget.Enabled = true;
                MessageBox.Show("deleted!", "Parallel Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ePdlt)
            {
                MessageBox.Show("Something went wrong!", "parallel sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnPadd_Click(object sender, EventArgs e)
        {
            try
            {


                if (drpdwnPsttime.Text == "" || drpdwnPdur.Text == "" || drpdwnPday.Text == "" || drpdwnPprg.Text == "")
                {
                    MessageBox.Show("Select details first!", "parallel sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else if (drpdwnPsubcode.Text == "")
                {
                    MessageBox.Show("Select subject code first!", "parallel sessions", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    dataSessionP1.Hide();
                    dataSessionP2.Show();
                    con.datasend("insert into parallel(parallelID,sTime,eTime,wd,programme,subcode) values('" + txtPID.Text + "','" + drpdwnPsttime.Text + "','" + drpdwnPdur.Text + "','" + drpdwnPday.Text + "','" + drpdwnPprg.Text + "','" + drpdwnPsubcode.Text + "')");
                    txtPID.Clear();
                    loadPPuser();
                    MessageBox.Show("Added!", "Parallel Sessions", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
            }
            catch (Exception ePadd)
            {
                MessageBox.Show(ePadd.Message, "Data could not be added!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                con.con.Close();
            }

        }

        private void btnNget_Click(object sender, EventArgs e)
        {
            
       
            if (drpdwnNsttime.Text == "")
            {
                MessageBox.Show("Select a start time!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (drpdwnNdur.Text == "")
            {
                MessageBox.Show("Select an end time!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (drpdwnNday.Text == "")
            {
                MessageBox.Show("Select a day!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else if (drpdwnNsubcode.Text == "")
            {
                MessageBox.Show("Select a programme!", "session Add", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            else
            {
                MessageBox.Show("Now select a programme", "sessions not available times");
                loadNuser();
            }
        
         }

        /*****************************************************************************session not available times tab*****************************************************************************/
        //Load Lecturer name in Combo box
        public void loadLecName()
        {
            DataBaseConnection conn = new DataBaseConnection();
            dataSet = conn.getData("select * from lecturer");

            cmbLec.DataSource = dataSet.Tables[0];
            cmbLec.DisplayMember = "lecturerName";
            cmbLec.ValueMember = "id";
        }

        //Load Group name in Combo box
        public void selectGroup()
        {

            DataBaseConnection conn = new DataBaseConnection();
            dataSet = conn.getData("select * from session");

            cmbgrp.DataSource = dataSet.Tables[0];
            cmbgrp.DisplayMember = "grpID";
            cmbgrp.ValueMember = "id";
        }

        //Load Sub Group name in Combo box
        public void subGroup()
        {
            DataBaseConnection conn = new DataBaseConnection();
            dataSet = conn.getData("select * from session");

            cmbsubgrp.DataSource = dataSet.Tables[0];
            cmbsubgrp.DisplayMember = "subgrpID";
            cmbsubgrp.ValueMember = "id";
        }

        //Load Session ID in Combo Box
        public void session()
        {
            DataBaseConnection conn = new DataBaseConnection();
            dataSet = conn.getData("select * from session");

            cmbsessionID.DataSource = dataSet.Tables[0];
            cmbsessionID.DisplayMember = "sessionID";
            cmbsessionID.ValueMember = "id";
        }

        //Submit Button 
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            String selectLec, selectGrp, selectSubGrp, selectSessionId, st, et;

            selectLec = cmbLec.Text;
            selectGrp = cmbgrp.Text;
            selectSubGrp = cmbsubgrp.Text;
            selectSessionId = cmbsessionID.Text;

            st = cmbsth2.Text + ":" + cmbstm2.Text;
            et = cmbeth2.Text + ":" + cmbetm2.Text;



            if (cmbsth2.Text == "" || cmbstm2.Text == "" || cmbeth2.Text == "" || cmbetm2.Text == "")
            {
                MessageBox.Show("Please Insert Time..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (selectLec == "" || selectGrp == "" || selectSubGrp == "" || selectSessionId == "")
            {
                MessageBox.Show("Please Insert Required Data..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                DataBaseConnection conn = new DataBaseConnection();
                conn.dataIUD("insert INTO notavailabletime VALUES ('id','" + selectLec + "', '" + selectGrp + "', '" + selectSubGrp + "',  '" + selectSessionId + "', '" + st + "', '" + et + "')");
                MessageBox.Show("Insert Successfull", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            viewOnDataGrid();
        }


        //clear button
        private void btnclear_Click(object sender, EventArgs e)
        {
            String message = "Do you want to process this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else if (result == DialogResult.OK)
            {
                clearAll();
                MessageBox.Show("Field Data Cleared.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {

            }
        }

        //clear
        private void clearAll()
        {
            cmbLec.SelectedIndex = -1;
            cmbgrp.SelectedIndex = -1;
            cmbsubgrp.SelectedIndex = -1;
            cmbsessionID.SelectedIndex = -1;

            txtid.Text = "";
        }

        //View Data on Grid
        private void viewOnDataGrid()
        {
            DataBaseConnection conn = new DataBaseConnection();
            DGWdata3.DataSource = conn.datafind("SELECT id as 'ID', selectLecturer as 'Lecturer', selectGroup as 'Group', selectSubGroup as 'Sub Group', selectSessionID as 'Session ID', st as 'Start Time', et as 'End Time' From notavailabletime");
        }


        // Start Time and End Time set to data grid
        private void ShowDuration(string st, string et)
        {
            char[] startTime = new char[5];
            startTime = st.ToCharArray();
            cmbsth2.Text = startTime[0].ToString() + startTime[1].ToString();
            cmbstm2.Text = startTime[3].ToString() + startTime[4].ToString();



            char[] endTime = new char[5];
            endTime = et.ToCharArray();
            cmbeth2.Text = endTime[0].ToString() + endTime[1].ToString();
            cmbetm2.Text = endTime[3].ToString() + endTime[4].ToString();

        }

        //Grid Data Slection fill fields
        private void DGWdata3_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < (DGWdata3.RowCount - 1))
            {
                txtid.Text = DGWdata3.SelectedRows[0].Cells[0].Value.ToString();
                cmbLec.Text = DGWdata3.SelectedRows[0].Cells[1].Value.ToString();
                cmbgrp.Text = DGWdata3.SelectedRows[0].Cells[2].Value.ToString();
                cmbsubgrp.Text = DGWdata3.SelectedRows[0].Cells[3].Value.ToString();
                cmbsessionID.Text = DGWdata3.SelectedRows[0].Cells[4].Value.ToString();
                string x = DGWdata3.SelectedRows[0].Cells[5].Value.ToString();
                string y = DGWdata3.SelectedRows[0].Cells[6].Value.ToString();
                ShowDuration(x, y);
            }
        }
        //Update Button 
        private void btnupdate_Click(object sender, EventArgs e)
        {
            String id, selectLec, selectGrp, selectSubGrp, selectSessionId, st, et;

            id = txtid.Text;
            selectLec = cmbLec.Text;
            selectGrp = cmbgrp.Text;
            selectSubGrp = cmbsubgrp.Text;
            selectSessionId = cmbsessionID.Text;
            st = cmbsth2.Text + ":" + cmbstm2.Text;
            et = cmbeth2.Text + ":" + cmbetm2.Text;


            string message = "Do you want to process this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else if (result == DialogResult.OK)
            {
                if (st == ":" || et == ":")
                {
                    MessageBox.Show("Please Insert Time..!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    DataBaseConnection conn = new DataBaseConnection();
                    conn.dataIUD("update  notavailabletime set selectLecturer= '" + selectLec + "' ,  selectGroup= '" + selectGrp + "' ,  selectSubGroup= '" + selectSubGrp + "'  ,  selectSessionId= '" + selectSessionId + "',st='" + st + "', et='" + et + "' where id= '" + id + "' ");
                    MessageBox.Show("successfully updated.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    viewOnDataGrid();
                }

            }
            else
            {

            }
        }

        //Delete Button 
        private void btndel_Click(object sender, EventArgs e)
        {
            String id;
            id = txtid.Text;

            string message = "Do you want to process this operation?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Warning);

            if (result == DialogResult.No)
            {
                this.Close();
            }
            else if (result == DialogResult.OK)
            {

                DataBaseConnection conn = new DataBaseConnection();
                conn.dataIUD("DELETE from notavailabletime WHERE id = '" + id + "'");
                MessageBox.Show("successfully Deleted.!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                viewOnDataGrid();
            }
            else
            {

            }

            viewOnDataGrid();
            clearAll();
        }

        //Search butoon
        private void bunibtnsrch_Click(object sender, EventArgs e)
        {
            searchData();
        }

        //Search button
        private void searchData()
        {
            String searchID;
            searchID = txtsrch.Text;

            DataBaseConnection conn = new DataBaseConnection();
            DGWdata3.DataSource = conn.datafind("select id'ID', selectLecturer'Lecturer', selectGroup'Group', selectSubGroup'Sub Group',selectSessionId'Session iD', st'Start Time', et'End Time'  from notavailabletime where id like'%" + searchID + "%'or selectLecturer like'%" + searchID + "%' or selectGroup like'%" + searchID + "%' or selectSubGroup like'%" + searchID + "%' or selectSessionId like'%" + searchID + "%' or st like'%" + searchID + "%' or et like'%" + searchID + "%'");

        }


        private void btnCclr_Click_1(object sender, EventArgs e)
        {
            
        }

       
    }
}
