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
    public partial class sub_static2 : Form

    {
        connect2 con2 = new connect2();//call class connect

        MySqlCommand cmd1, cmd2, cmd3, cmd4, cmd5;
        MySqlDataReader reader2;
        MySqlDataAdapter adapter2;
        //DataTable dt;
        DataSet ds2;

        private double firs_sub;
        private double sec_sub;
        private double thir_sub;
        private double fou_sub;
        private double Total;
    


        public sub_static2()
        {
            InitializeComponent();
        }

        private void sub_static2_Load(object sender, EventArgs e)
        {
            count_sub();
            chart_load_subj();
        }

        public void chart_load_subj()
        {
            chart1.Series["Number Of Student"].Points.AddXY("1St Year", firs_sub);
            chart1.Series["Number Of Student"].Points.AddXY("2nd Year", sec_sub);
            chart1.Series["Number Of Student"].Points.AddXY("3rd Year", thir_sub);
            chart1.Series["Number Of Student"].Points.AddXY("4rd Year", fou_sub);

        }

        


        public void count_sub()
        {
            try
            {
                con2.connection();
                MessageBox.Show("connectionsuccess full!");
                cmd1 = new MySqlCommand("SELECT COUNT(*) FROM subject where offeredYear = 'Year 1 '", con2.con2);
                cmd2 = new MySqlCommand("SELECT COUNT(*) FROM subject where offeredYear = 'Year 2 '", con2.con2);
                cmd3 = new MySqlCommand("SELECT COUNT(*) FROM subject where offeredYear = 'Year 3 '", con2.con2);
                cmd4 = new MySqlCommand("SELECT COUNT(*) FROM subject where offeredYear = 'Year 4 '", con2.con2);
                cmd5 = new MySqlCommand("SELECT COUNT(*) FROM subject", con2.con2);
                // adapter = new MySqlDataAdapter(cmd);
                //   ds = new DataSet();
                //  adapter.Fill(ds);
                //dataSession.DataSource = ds;
                // con.con.Close();

                Int32 Count1_sub = Convert.ToInt32(cmd1.ExecuteScalar());
                Int32 Count2_sub = Convert.ToInt32(cmd2.ExecuteScalar());
                Int32 Count3_sub = Convert.ToInt32(cmd3.ExecuteScalar());
                Int32 Count4_sub = Convert.ToInt32(cmd4.ExecuteScalar());
                Int32 Count_total_sub = Convert.ToInt32(cmd5.ExecuteScalar());


                textBox2.Text = Count1_sub.ToString();
                textBox4.Text = Count2_sub.ToString();
                textBox3.Text = Count3_sub.ToString();
                textBox8.Text = Count4_sub.ToString();
                textBox1.Text = Count_total_sub.ToString();


                firs_sub = Count1_sub;
                sec_sub = Count2_sub;
                thir_sub = Count3_sub;
                fou_sub = Count4_sub;



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
