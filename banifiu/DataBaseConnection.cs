using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace banifiu
{
    class DataBaseConnection
    {

        MySqlConnection scon;
        MySqlCommand scmd;
        MySqlDataAdapter da;
        MySqlDataReader reader;
        DataTable dt;
        DataSet ds;



        public DataTable datafind(string query)
        {
            try
            {
                scon = new MySqlConnection("server=itpm1.mysql.database.azure.com;uid=chmd@itpm1;pwd=Itpm@153708113;database=timetablemanagement; ");
                //scon = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=timetablemanagement; ");
                scon.Open();
                scmd = new MySqlCommand(query, scon);
                da = new MySqlDataAdapter(scmd);
                dt = new DataTable();
                da.Fill(dt);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                da.Dispose();
                scon.Close();
            }
            finally
            {
                da.Dispose();
                scon.Close();
            }
            return dt;
        }

        public DataSet getData(string query)
        {
            try
            {
                scon = new MySqlConnection("server=itpm1.mysql.database.azure.com;uid=chmd@itpm1;pwd=Itpm@153708113;database=timetablemanagement");
                //scon = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=timetablemanagement; ");
                scon.Open();
                scmd = new MySqlCommand(query, scon);
                da = new MySqlDataAdapter(scmd);

                ds = new DataSet();
                da.Fill(ds);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                da.Dispose();
                scon.Close();
            }
            finally
            {
                da.Dispose();
                scon.Close();
            }
            return ds;
        }

        public void dataIUD(string query)
        {
            scon = new MySqlConnection("server=itpm1.mysql.database.azure.com;uid=chmd@itpm1;pwd=Itpm@153708113;database=timetablemanagement;");
            // scon = new MySqlConnection("server=127.0.0.1;uid=root;pwd=;database=timetablemanagement; ");
            try
            {
                scon.Open();
                scmd = new MySqlCommand(query, scon);
                scmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                scon.Close();
            }
            finally
            {
                scon.Close();
            }
        }

    }
}
