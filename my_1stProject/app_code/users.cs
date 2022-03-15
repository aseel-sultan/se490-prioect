using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace my_1stProject.app_code
{
    public class users
    {
        //add new user
        public static void insert(int uNum, string uName, string password)
        {
            string query = "insert into users (Unumber,Uname,password) values(@uNum,@uName ,@password) ";

            SqlCommand cmd = new SqlCommand(query, DBcon.con);
            DBcon.open();

            cmd.Parameters.AddWithValue("@uNum", uNum);
            cmd.Parameters.AddWithValue("@uName", uName);
            cmd.Parameters.AddWithValue("@password", password);


            cmd.ExecuteNonQuery();

            DBcon.close();

        }




        // حذف مستخدم

        public static void delete(int number)
        {
            string query = "delete from users where Unumber=@number";

            SqlCommand cmd = new SqlCommand(query, DBcon.con);
            DBcon.open();
            cmd.Parameters.AddWithValue("@number", number);

            cmd.ExecuteNonQuery();

            DBcon.close();

        }



 

        // تعديل بيانات مستخدم "تغيير الباسوورد"

        public static void update(int number, string pass)
        {

            string query = "update users set password = @pass where Unumber =@number";
            SqlCommand cmd = new SqlCommand(query, DBcon.con);

            DBcon.open();

            cmd.Parameters.AddWithValue("@number", number);
            cmd.Parameters.AddWithValue("@pass", pass);

            cmd.ExecuteNonQuery();
            DBcon.close();

        }
        //search method return true if the user is found or false if not found
        public static Boolean search(int num)
        {
            String query = "select Unumber from users where Unumber=@num";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, DBcon.con);

            dataAdapter.SelectCommand.Parameters.AddWithValue("@num", num);

            DataTable dt = new DataTable();
            dataAdapter.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }//end search method


        //view method
        public static DataTable selectData()
        {
            DataTable dt = new DataTable();
            string query = "select Unumber,Uname,password from users";
            SqlDataAdapter da = new SqlDataAdapter(query, DBcon.con);
            da.Fill(dt);
            return dt;
        }
    }

}
