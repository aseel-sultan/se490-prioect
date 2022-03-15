using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace my_1stProject.forms
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {

            try
            {
                int Unum = int.Parse(nameText.Text.Trim());
                string password = passText.Text;




                String query = "select Unumber from users where Unumber=@Unum and password=@password";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(query, app_code.DBcon.con);

                dataAdapter.SelectCommand.Parameters.AddWithValue("@Unum", Unum);
                dataAdapter.SelectCommand.Parameters.AddWithValue("@password", password);

                DataTable dt = new DataTable();
                dataAdapter.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    mainPage main = new mainPage();
                                main.Show();
                               this.Hide();
                                 
                }
                else
                {
                    MessageBox.Show("يرجى التأكد من رقم المستخدم وكلمة المرور");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ في الادخال يرجى اعادة المحاولة");
            }
           

                      

        }
    }
}
