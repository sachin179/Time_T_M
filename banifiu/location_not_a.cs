using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
namespace banifiu
{
    public partial class location_not_a : Form
    {
        DataSet dataset;
        DataTable dtlocal;

        public location_not_a()
        {
            InitializeComponent();
        }
        public void loadSelectDay()
        {
            DataBaseConnection conn = new DataBaseConnection();
            dataset = conn.getData("select * from new_table");

            combrm.DataSource = dataset.Tables[0];
            combrm.DisplayMember = "room";
            combrm.ValueMember = "id";

        }

        private void AddLocations_Load(object sender, EventArgs e)
        {
            loadSelectDay();
            viewOnDataGrid();
        }

        private void viewOnDataGrid()
        {
            DataBaseConnection conn = new DataBaseConnection();
            dataGridView1.DataSource = conn.datafind("SELECT id as 'ID', room as 'Room', date as 'Date', st as 'Start Time', et as 'End Time' From addnotavailabletimelocations");
        }

        private void ShowDuration(string st, string et)
        {
            char[] startTime = new char[5];
            startTime = st.ToCharArray();
            cmbsrt1.Text = startTime[0].ToString() + startTime[1].ToString();
            cmbsrt2.Text = startTime[3].ToString() + startTime[4].ToString();



            char[] endTime = new char[5];
            endTime = et.ToCharArray();
            cmbed1.Text = endTime[0].ToString() + endTime[1].ToString();
            cmbed2.Text = endTime[3].ToString() + endTime[4].ToString();

        }

        private void showDate(string day)
        {


            char[] d = new char[10];
            d = day.ToCharArray();
            cmbD.Text = d[0].ToString() + d[1].ToString();
            cmbM.Text = d[3].ToString() + d[4].ToString();
            cmbY.Text = d[6].ToString() + d[7].ToString() + d[8].ToString() + d[9].ToString();
        }

        private void btninsert3_Click(object sender, EventArgs e)
        {
            string sr, st, et, date;
            sr = combrm.Text;

            st = cmbsrt1.Text + ":" + cmbsrt2.Text;
            et = cmbed1.Text + ":" + cmbed2.Text;

            date = cmbD.Text + "-" + cmbM.Text + "-" + cmbY.Text;

            if (combrm.Text == "" || cmbD.SelectedIndex == -1 || cmbM.SelectedIndex == -1 || cmbY.SelectedIndex == -1 || cmbsrt1.SelectedIndex == -1 || cmbsrt2.SelectedIndex == -1 || cmbed1.SelectedIndex == -1 || cmbed2.SelectedIndex == -1)
            {
                MessageBox.Show("Please FIll Required Fields", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

            else
            {
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
                    conn.dataIUD("insert INTO addnotavailabletimelocations VALUES ('id','" + sr + "', '" + date + "', '" + st + "',  '" + et + "')");
                    MessageBox.Show("Record Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    viewOnDataGrid();
                }
                else
                {

                }
            }
        }

        private void btnclear3_Click(object sender, EventArgs e)
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

        private void clearAll()
        {
            combrm.Text = "";
            cmbsrt1.SelectedIndex = -1;
            cmbsrt2.SelectedIndex = -1;
            cmbed1.SelectedIndex = -1;
            cmbed2.SelectedIndex = -1;
            cmbD.SelectedIndex = -1;
            cmbM.SelectedIndex = -1;
            cmbY.SelectedIndex = -1;
        }

        private void DGWdata4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.RowIndex < (dataGridView1.RowCount - 1))
            {
                textid.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                combrm.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                string dy = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                showDate(dy);
                string x = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                string y = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                ShowDuration(x, y);
            }
            //else
            //{
            //    MessageBox.Show("Please Select Valied Cell", "Attantion", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            //}

            //txtid.Text = e.RowIndex.ToString()+","+ DGWdata4.RowCount.ToString();
        }



        private void btndel3_Click(object sender, EventArgs e)
        {
            String id;
            id = textid.Text;

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
                conn.dataIUD("DELETE from addnotavailabletimelocations WHERE id = '" + id + "'");
                MessageBox.Show("Delete Successfull.!", "Sucess", MessageBoxButtons.OK, MessageBoxIcon.Information);
                viewOnDataGrid();
                clearAll();
            }
            else
            {

            }
        }

        private void btnupdate3_Click(object sender, EventArgs e)
        {
            String id, sr, date, st, et;

            id = textid.Text;
            sr = combrm.Text;
            date = cmbD.Text + "-" + cmbM.Text + "-" + cmbY.Text;
            st = cmbsrt1.Text + ":" + cmbsrt2.Text;
            et = cmbed1.Text + ":" + cmbed2.Text;


            DataBaseConnection conn = new DataBaseConnection();
            conn.dataIUD("update  addnotavailabletimelocations set room= '" + sr + "' ,  date= '" + date + "' ,  st= '" + st + "'  ,  et= '" + et + "' where id= '" + id + "' ");
            MessageBox.Show("Record Added", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

            viewOnDataGrid();
        }

        private void bunibtnsrch3_Click(object sender, EventArgs e)
        {
            searchData();
        }

        private void searchData()
        {
            String searchID;

            searchID = bunifuThinButton21.Text;

            DataBaseConnection conn = new DataBaseConnection();

            dataGridView1.DataSource = conn.datafind("select id'ID', room'Room', date'Date', st'Start Time',et'End Time' from addnotavailabletimelocations where id like'%" + searchID + "%' or room like'%" + searchID + "%' or date like'%" + searchID + "%' or st like'%" + searchID + "%' or et like'%" + searchID + "%'");


        }

        private void bunifuGradientPanel6_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {

        }

        private void location_not_a_Load(object sender, EventArgs e)
        {
            loadSelectDay();
            viewOnDataGrid();
        }
    }
}
