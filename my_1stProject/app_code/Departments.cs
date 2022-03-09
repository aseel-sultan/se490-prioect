using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace my_1stProject.app_code
{
    class Departments
    {
        public static void Insert(string DepName)
        {
            string query = "INSERT INTO Department VALUES (@DepName);";
            SqlCommand cmd = new SqlCommand(query,DBcon.con);
            DBcon.open();
            cmd.ExecuteReader();
            DBcon.close();
        }

        public static void Update(int id, string DepName)
        {
            string query = "Update Department set Name='DepName' where id=@id";
            SqlCommand cmd = new SqlCommand(query, DBcon.con);
            cmd.Parameters.AddWithValue("@DepName",DepName);
            DBcon.open();
            cmd.ExecuteReader();
            DBcon.close();
        }

        public static void Update(int id)
        {
            string query = "Delete from  Department where id=@id";
            SqlCommand cmd = new SqlCommand(query, DBcon.con);
            cmd.Parameters.AddWithValue("@id",id);
            DBcon.open();
            cmd.ExecuteReader();
            DBcon.close();
        }
    }
}
