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
    public partial class St_Static : Form
    {
        connect2 con2 = new connect2();//call class connect

        MySqlCommand cmd1, cmd2, cmd3, cmd4 ,cmd5;
        MySqlCommand cmd11, cmd22, cmd33, cmd44, cmd55;
        MySqlDataReader reader2;
        MySqlDataAdapter adapter2;
        //DataTable dt;
        DataSet ds2;

        private double firstYear;
        private double secondYear;
        private double thirdYear;
        private double fourthYear;
        private double total;

        private double it;
        private double csne;
        private double se;
        private double cs;
        private double im;


        public St_Static()
        {
            InitializeComponent();
        }

        public void chart_load()
        {
            chart1.Series["Number Of Student"].Points.AddXY("1St Year", firstYear);
            chart1.Series["Number Of Student"].Points.AddXY("2nd Year", secondYear);
            chart1.Series["Number Of Student"].Points.AddXY("3rd Year", thirdYear);
            chart1.Series["Number Of Student"].Points.AddXY("4rd Year", fourthYear);

        }


        public void count_student()
        {
            try
            {
                con2.connection();
                MessageBox.Show("connectionsuccess full!");
                cmd1 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where academicYear = 'Y1.S1'", con2.con2);
                cmd2 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where academicYear = 'Y2.S1'", con2.con2);
                cmd3 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where academicYear = 'Y3.S1'", con2.con2);
                cmd4 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where academicYear = 'Y4.S1'", con2.con2);
                cmd5 = new MySqlCommand("SELECT COUNT(*) FROM studentadd  ", con2.con2);

                cmd11 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where programme = 'Information Technology'", con2.con2);
                cmd22 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where programme = 'Computer System Network '", con2.con2);
                cmd33 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where programme = 'Cyber Security'", con2.con2);
                cmd44 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where programme = 'Software Engineering'", con2.con2);
                cmd55 = new MySqlCommand("SELECT COUNT(*) FROM studentadd where programme = 'Interactive Media'", con2.con2);

                // adapter = new MySqlDataAdapter(cmd);
                //   ds = new DataSet();
                //  adapter.Fill(ds);
                //dataSession.DataSource = ds;
                // con.con.Close();

                Int32 Count1year = Convert.ToInt32(cmd1.ExecuteScalar());
                Int32 Count2year = Convert.ToInt32(cmd2.ExecuteScalar());
                Int32 Count3year = Convert.ToInt32(cmd3.ExecuteScalar());
                Int32 Count4year = Convert.ToInt32(cmd4.ExecuteScalar());
                Int32 Count_total = Convert.ToInt32(cmd5.ExecuteScalar());

                Int32 count_it = Convert.ToInt32(cmd11.ExecuteScalar());
                Int32 count_csne = Convert.ToInt32(cmd22.ExecuteScalar());
                Int32 count_se = Convert.ToInt32(cmd33.ExecuteScalar());
                Int32 count_cs = Convert.ToInt32(cmd44.ExecuteScalar());
                Int32 count_im = Convert.ToInt32(cmd55.ExecuteScalar());

                //count subjetc vice
                textBox7.Text = count_it.ToString();
                textBox6.Text = count_csne.ToString();
                textBox5.Text = count_se.ToString();
                textBox9.Text = count_cs.ToString();
                textBox10.Text = count_im.ToString();

                //count year
                textBox2.Text = Count1year.ToString();
                textBox4.Text = Count2year.ToString();
                textBox3.Text = Count3year.ToString();
                textBox8.Text = Count4year.ToString();
                textBox1.Text = Count_total.ToString();

                //asing year count
                firstYear = Count1year;
                secondYear = Count2year;
                thirdYear = Count3year;
                fourthYear = Count4year;
             



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


        private void St_Static_Load(object sender, EventArgs e)
        {
            count_student();
            chart_load();
        }
    }
}
