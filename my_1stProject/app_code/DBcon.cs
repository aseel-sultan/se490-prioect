using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace my_1stProject.app_code
{
    class DBcon
    {
        //make connection
        static string connectionstring =
             "server=DESKTOP-54L3EJD ;Database=resturant;  trusted_connection=true";
        static public SqlConnection con = new SqlConnection(connectionstring);




        //method to open connection
        static public void open()
        {
            if (con.State == ConnectionState.Closed)
                con.Open();

        }

        //method to close connection
        static public void close()
        {
            if (con.State == ConnectionState.Open)
                con.Close();

        }
    }
}
