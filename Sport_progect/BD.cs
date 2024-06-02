using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO.Packaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sport_progect
{
    class BD
    {
        private static string ConfStr = ConfigurationManager.ConnectionStrings["ServerCS"].ConnectionString;
        private MySqlConnection con = new MySqlConnection(ConfStr);

        public async void OpenCon()
        { 
            if(con.State == System.Data.ConnectionState.Closed)
            {
                await con.OpenAsync();
            }
        }

        public async void CloseCon()
        { 
            if(con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }
        }

        public MySqlConnection getCon()
        {
            return con;
        }
    }
}
