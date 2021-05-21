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
    public partial class working : Form
    {

        DataTable dtlocal;
        string[] strDays = { "no", "no", "no", "no", "no", "no", "no" };
        // string[] srtDayNames = new string[7];
        int dayCount = 0;
        public working()
        {
            InitializeComponent();
        }

     

        private void Form1_Load(object sender, EventArgs e)
        {
            string q = "SELECT id as 'Id', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday`";
            viewOnDataGrid(q);
            resetStrDays();
        }

        //Search Data
        private void searchData(string id)
        {
            string q;
            DataBaseConnection conn = new DataBaseConnection();
            dtlocal = conn.datafind("Select * from workday where id='" + id + "'");
            if (dtlocal.Rows.Count > 0)
            {
                txtLid.Text = dtlocal.Rows[0][0].ToString();
                lblDay.Text = dtlocal.Rows[0][1].ToString();
                Viewdays(dtlocal.Rows[0][2].ToString());
                string x = dtlocal.Rows[0][3].ToString();
                string y = dtlocal.Rows[0][4].ToString();
                ShowDuration(x, y);
                q = "SELECT id as 'Lecture', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday` where id='" + id + "'";
            }
            else
            {
                if (txtLid.Text == "")
                {
                    q = "SELECT id as 'Lecture', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday`";
                }
                else
                {
                    q = "SELECT id as 'Lecture', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday` where id='" + id + "'";
                    MessageBox.Show("Please Insert Valied ID", "Failed to Find", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }

            viewOnDataGrid(q);
        }


        //Create Day
        private string createDaysString(string[] x)
        {
            string sout = "";
            if (x[0] == "yes")
            {
                sout = "Monday,";
            }
            if (x[1] == "yes")
            {
                sout = sout + "Tuesday,";
            }
            if (x[2] == "yes")
            {
                sout = sout + "Wednesday,";
            }
            if (x[3] == "yes")
            {
                sout = sout + "Thursday,";
            }
            if (x[4] == "yes")
            {
                sout = sout + "Friday,";
            }
            if (x[5] == "yes")
            {
                sout = sout + "Saturday,";
            }
            if (x[6] == "yes")
            {
                sout = sout + "Sunday,";
            }
            return (sout);
        }


        private void Viewdays(string dayString)
        {

            clearAllDays();
            string dayName = "";

            char[] dayChar = dayString.ToCharArray();
            foreach (char y in dayChar)
            {
                if (y != ',')
                {
                    dayName = dayName + y.ToString();
                }
                else
                {
                    setcheckBox(dayName);
                    dayName = "";
                }

            }

        }


        // Start Time and End Time Get On Grid
        private void ShowDuration(string st, string et)
        {
            char[] startTime = new char[5];
            startTime = st.ToCharArray();
            cmbSh.Text = startTime[0].ToString() + startTime[1].ToString();
            cmbSm.Text = startTime[3].ToString() + startTime[4].ToString();



            char[] endTime = new char[5];
            endTime = et.ToCharArray();
            cmbEh.Text = endTime[0].ToString() + endTime[1].ToString();
            cmbEm.Text = endTime[3].ToString() + endTime[4].ToString();

        }

        //Clear All Days
        private void clearAllDays()
        {
            chbxMon.Checked = false;
            chbxTus.Checked = false;
            chbxWed.Checked = false;
            chbxThu.Checked = false;
            chbxFri.Checked = false;
            chbxSat.Checked = false;
            chbxSun.Checked = false;

        }

        private void setcheckBox(string dayName)
        {
            if (dayName == "Monday")
            {
                chbxMon.Checked = true;
            }
            else if (dayName == "Tuesday")
            {
                chbxTus.Checked = true;
            }
            else if (dayName == "Wednesday")
            {
                chbxWed.Checked = true;
            }
            else if (dayName == "Thursday")
            {
                chbxThu.Checked = true;
            }
            else if (dayName == "Friday")
            {
                chbxFri.Checked = true;
            }
            else if (dayName == "Saturday")
            {
                chbxSat.Checked = true;
            }
            else if (dayName == "Sunday")
            {
                chbxSun.Checked = true;
            }

        }

        //View Data On Grid
        private void viewOnDataGrid(string q)
        {
            DataBaseConnection conn = new DataBaseConnection();
            DGWdata.DataSource = conn.datafind(q);
        }

        //Reset CheckBox
        private void resetStrDays()
        {
            int i = 0;
            while (i < 7)
            {
                strDays[i] = "no";
                i++;
            }
        }

        //Clear All
        private void clearAll()
        {
            txtLid.Text = "";
            lblDay.Text = "";
            cmbSh.Text = "";
            cmbSm.Text = "";
            cmbEh.Text = "";
            cmbEm.Text = "";
            clearAllDays();
        }


        //Show Day Count Lable
        private void showDaycount()
        {
            dayCount = 0;

            //sunday
            if (chbxSun.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[6] = "yes";
            }
            else
            {
                strDays[6] = "no";
            }
            //saturday
            if (chbxSat.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[5] = "yes";
            }
            else
            {
                strDays[5] = "no";
            }
            //friday
            if (chbxFri.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[4] = "yes";
            }
            else
            {
                strDays[4] = "no";
            }
            //thursday
            if (chbxThu.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[3] = "yes";
            }
            else
            {
                strDays[3] = "no";
            }
            //wednesday
            if (chbxWed.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[2] = "yes";
            }
            else
            {
                strDays[2] = "no";
            }
            //tuesday
            if (chbxTus.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[1] = "yes";
            }
            else
            {
                strDays[1] = "no";
            }
            //monday
            if (chbxMon.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[0] = "yes";
            }
            else
            {
                strDays[0] = "no";
            }

            lblDay.Text = dayCount.ToString();
        }

        //Search Button
        private void btnSearch_Click(object sender, EventArgs e)
        {
            searchData(txtLid.Text);

        }

        //Get Check Box data
        private void chbxMon_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxMon.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[0] = "yes";
            }
            else
            {
                dayCount = dayCount - 1;
                strDays[0] = "no";
            }

            lblDay.Text = dayCount.ToString();
        }

        private void chbxTus_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxTus.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[1] = "yes";
            }
            else
            {
                dayCount = dayCount - 1;
                strDays[1] = "no";
            }
            lblDay.Text = dayCount.ToString();
        }

        private void chbxWed_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxWed.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[2] = "yes";
            }
            else
            {
                dayCount = dayCount - 1;
                strDays[2] = "no";
            }
            lblDay.Text = dayCount.ToString();
        }

        private void chbxThu_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxThu.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[3] = "yes";
            }
            else
            {
                dayCount = dayCount - 1;
                strDays[3] = "no";
            }
            lblDay.Text = dayCount.ToString();
        }

        private void chbxFri_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxFri.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[4] = "yes";
            }
            else
            {
                dayCount = dayCount - 1;
                strDays[4] = "no";
            }
            lblDay.Text = dayCount.ToString();
        }

        private void chbxSat_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSat.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[5] = "yes";
            }
            else
            {
                dayCount = dayCount - 1;
                strDays[5] = "no";
            }
            lblDay.Text = dayCount.ToString();
        }

        private void chbxSun_CheckedChanged(object sender, EventArgs e)
        {
            if (chbxSun.Checked == true)
            {
                dayCount = dayCount + 1;
                strDays[6] = "yes";
            }
            else
            {
                dayCount = dayCount - 1;
                strDays[6] = "no";
            }

            lblDay.Text = dayCount.ToString();
        }

        //Submit Button 
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id, nod, wd, st, et;
            id = txtLid.Text;
            nod = dayCount.ToString();
            showDaycount();
            wd = createDaysString(strDays);
            st = cmbSh.Text + ":" + cmbSm.Text;
            et = cmbEh.Text + ":" + cmbEm.Text;

            DataBaseConnection conn = new DataBaseConnection();
            conn.dataIUD("insert INTO workday (`nod`, `wd`, `sTime`, `eTime`) VALUES ('" + nod + "','" + wd + "','" + st + "','" + et + "')");
            MessageBox.Show("Record Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string q = "SELECT id as 'Lecture', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday`";
            viewOnDataGrid(q);
        }

        //Update Button
        private void btnUpd_Click(object sender, EventArgs e)
        {
            string id, nod, wd, st, et;
            id = txtLid.Text;
            nod = dayCount.ToString();
            showDaycount();
            wd = createDaysString(strDays);
            st = cmbSh.Text + ":" + cmbSm.Text;
            et = cmbEh.Text + ":" + cmbEm.Text;

            DataBaseConnection conn = new DataBaseConnection();
            conn.dataIUD("update workday set nod='" + nod + "', wd='" + wd + "',sTime='" + st + "',eTime='" + et + "' where id='" + id + "'");
            MessageBox.Show("Record Uptade", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string q = "SELECT id as 'Lecture', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday`";
            viewOnDataGrid(q);
        }

        //Delete Button 
        private void btnDlt_Click(object sender, EventArgs e)
        {
            DataBaseConnection conn = new DataBaseConnection();
            conn.dataIUD("DELETE from workday WHERE id = '" + txtLid.Text + "'");
            MessageBox.Show("Record Delete", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            string q = "SELECT id as 'Lecture', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday`";
            viewOnDataGrid(q);
            clearAll();
        }

        //Clear Button
        private void btnClear_Click(object sender, EventArgs e)
        {
            clearAll();
        }


        //Grid Data Selection
        private void DGWdata_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string id = "";
            if (e.RowIndex > 0)
            {
                id = Convert.ToString(DGWdata.Rows[e.RowIndex].Cells[0].Value);
                if (id != "")
                {
                    searchData(id);
                }
            }

        }

        private void working_Load(object sender, EventArgs e)
        {
            string q = "SELECT id as 'Id', nod as 'Number of Days', wd as 'Work Days', sTime as 'Start Time',eTime as 'End Time' FROM `workday`";
            viewOnDataGrid(q);
            resetStrDays();
        }
    }
}
