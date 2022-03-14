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
    public partial class updatePage : Form
    {
        public updatePage()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        //للتعديل
        private void button1_Click(object sender, EventArgs e)
        {

            int num =int.Parse(number.Text.Trim());

            Boolean check = app_code.users.search(num);

            if (check == true)
            {
                if (pass.Text.Equals(pass2.Text) != true)

                    MessageBox.Show("يرجى التأكد من تطابق كلمة المرور");

                else
                {
                    app_code.users.update(num, pass.Text);

                    MessageBox.Show("تم التعديل");
                    Close();

                }
            }
            else
            {
                MessageBox.Show("فشل عملية التعديل هذا المستخدم غير موجود");

            }
            

        }
        //للرجوع
        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void updatePage_Load(object sender, EventArgs e)
        {

        }
    }
}
