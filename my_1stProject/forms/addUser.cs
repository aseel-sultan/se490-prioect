using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace my_1stProject.forms
{
    public partial class addUser : Form
    {
        public addUser()
        {
            InitializeComponent();
        }
        usersPage UPage = new usersPage();

       
        //add user
        private void button2_Click(object sender, EventArgs e)
        {


            try
            {
                int Num = int.Parse(uNum.Text.Trim());
                string name = uName.Text.Trim();
                string password = pass1.Text;
                string password2 = pass2.Text;


                Boolean check = app_code.users.search(Num);
                if (check == false)
                {

                    if (name == "" ||  password == "")
                    {
                        MessageBox.Show("يرجى التأكد من ادخال جميع البيانات");

                    }
                    else  if (password.Equals(password2) != true)
                    {
                        MessageBox.Show("يرجى التأكد من تطابق كلمة المرور");

                    }
                    else
                    {
                        app_code.users.insert(Num, name, password);
                        MessageBox.Show("تمت الاضافة بنجاح");

                        this.Close();


                        UPage.Show();
                    }
                }// end if(check)

                else
                {
                    MessageBox.Show("هذا المستخدم موجود لا يمكن اضافته");

                }
            }
            catch (Exception)
            {
                MessageBox.Show("خطأ في الادخال يرجى اعادة المحاولة");

            }
               

           

        }




        private void back_Click(object sender, EventArgs e)
        {
            UPage.Show();
            this.Close();
        }
    }
}
