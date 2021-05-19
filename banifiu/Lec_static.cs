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
    public partial class Lec_static : Form
    {
        connect2 con2 = new connect2();//call class connect

        MySqlCommand cmd1, cmd2, cmd3, cmd4 , cmd5 , cmd6 ,cmd7 ;
        // MySqlDataReader reader;
        MySqlDataAdapter adapter;
        //DataTable dt;
        DataSet ds;

        private double pro;
        private double ass_pro;
        private double senior_hg;
        private double senior;
        private double lecture;
        private double ass_lect;
        private double total;

        public Lec_static()
        {
            InitializeComponent();
        }

        private void Lec_static_Load(object sender, EventArgs e)
        {
            count_lecture();
            chart_load_lec();

        }

        public void chart_load_lec()
        {
            chart1.Series["Number Of Lectures"].Points.AddXY("1St Year", pro);
            chart1.Series["Number Of Lectures"].Points.AddXY("2nd Year", ass_pro);
            chart1.Series["Number Of Lectures"].Points.AddXY("3rd Year", senior_hg);
            chart1.Series["Number Of Lectures"].Points.AddXY("4rd Year", senior);
            chart1.Series["Number Of Lectures"].Points.AddXY("4rd Year", lecture);
            chart1.Series["Number Of Lectures"].Points.AddXY("4rd Year", ass_lect);

        }

        public void count_lecture()
        {
            try
            {
                con2.connection();
              //  MessageBox.Show("connectionsuccess full!");
                cmd1 = new MySqlCommand("SELECT COUNT(*) FROM lecturer where level = 1", con2.con2);
                cmd2 = new MySqlCommand("SELECT COUNT(*) FROM lecturer where level = 2", con2.con2);
                cmd3 = new MySqlCommand("SELECT COUNT(*) FROM lecturer where level = 3", con2.con2);
                cmd4 = new MySqlCommand("SELECT COUNT(*) FROM lecturer where level = 4", con2.con2);
                cmd5 = new MySqlCommand("SELECT COUNT(*) FROM lecturer where level = 5", con2.con2);
                cmd6 = new MySqlCommand("SELECT COUNT(*) FROM lecturer where level = 6", con2.con2);
                cmd7 = new MySqlCommand("SELECT COUNT(*) FROM lecturer ", con2.con2);
             

                Int32 count_pro = Convert.ToInt32(cmd1.ExecuteScalar());
                Int32 Count_ass_pro = Convert.ToInt32(cmd2.ExecuteScalar());
                Int32 Count_senior_hg = Convert.ToInt32(cmd3.ExecuteScalar());
                Int32 Count_senior = Convert.ToInt32(cmd4.ExecuteScalar());
                Int32 Count_lecture = Convert.ToInt32(cmd5.ExecuteScalar());
                Int32 Count_ass_lect = Convert.ToInt32(cmd6.ExecuteScalar());
                Int32 Count_total = Convert.ToInt32(cmd7.ExecuteScalar());



                textBox2.Text = count_pro.ToString();
                textBox4.Text = Count_ass_pro.ToString();
                textBox3.Text = Count_senior_hg.ToString();
                textBox9.Text = Count_senior.ToString();
                textBox8.Text = Count_lecture.ToString();
                textBox10.Text = Count_ass_lect.ToString();
                textBox1.Text = Count_total.ToString();


                pro = count_pro;
                ass_pro = Count_ass_pro;
                senior_hg = Count_senior_hg;
                senior = Count_senior;
                lecture = Count_lecture;
                ass_lect = Count_ass_lect;



            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                if (con2.con2.State == ConnectionState.Open)
                {
                    con2.con2.Close();
                }
            }

        }


    }
}
