﻿using System;
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
            string Uname = nameText.Text.Trim();
                        string password = passText.Text;

                        SqlCommand com = new SqlCommand();

                        app_code.DBcon.open();
                        com.Connection = app_code.DBcon.con;

            com.CommandText="select * from users ";

            SqlDataReader rd = com.ExecuteReader();

            if (rd.Read())
            {
                // اذا كان الاسم والباسوورد صحيحات ينتقل الى الصفحة الرئيسية
                if (Uname.Equals(rd["Uname"].ToString()) && password.Equals(rd["password"].ToString()))
                {
                    
                    mainPage main = new mainPage();
                    main.Show();
                   // Close();
                }



                else
                    MessageBox.Show("يرجى التأكد من اسم المستخدم وكلمة المرور");

            }



            app_code.DBcon.close();


                      

        }
    }
}