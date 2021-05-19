using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace banifiu
{
   

    class connect
    {
        public MySqlConnection con;
        public MySqlCommand cmd;
        public MySqlDataReader reader;

        public void connection()
        {
            con = new MySqlConnection("datasource=localhost; database=addlocation; port=3306; username=root;password=root");
            con.Open();

        }
        public void datasend(string sql)//add data
        {
            connection();
            cmd = new MySqlCommand(sql, con);
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public void dataupdate(string sql)//update data
        {
            connection();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            con.Close();
        }
        public void datadelete(string sql)//delete data
        {
            connection();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            con.Close();
        }
        public void dataget(string sql)//get data
        {
            connection();
            cmd = new MySqlCommand(sql, con);
            reader = cmd.ExecuteReader();
            con.Close();
        }

    }
}
