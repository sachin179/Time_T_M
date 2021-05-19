using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace banifiu
{
    class connect2
    {
        public MySqlConnection con2;
        public MySqlCommand cmd2;
        public MySqlDataReader reader2;

        public void connection()
        {
            con2 = new MySqlConnection("datasource=localhost; database=studentdb; port=3306; username=root;password=root");
            con2.Open();

        }
        public void datasend(string sql)//add data
        {
            connection();
            cmd2 = new MySqlCommand(sql, con2);
            cmd2.ExecuteNonQuery();
            con2.Close();
        }
        public void dataupdate(string sql)//update data
        {
            connection();
            cmd2 = new MySqlCommand(sql, con2);
            reader2 = cmd2.ExecuteReader();
            con2.Close();
        }
        public void datadelete(string sql)//delete data
        {
            connection();
            cmd2 = new MySqlCommand(sql, con2);
            reader2 = cmd2.ExecuteReader();
            con2.Close();
        }
        public void dataget(string sql)//get data
        {
            connection();
            cmd2 = new MySqlCommand(sql, con2);
            reader2 = cmd2.ExecuteReader();
            con2.Close();
        }

    }
}
