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
    public partial class deletePage : Form
    {
        public deletePage()
        {
            InitializeComponent();
        }

       

        private void button1_Click(object sender, EventArgs e)
        {
            int num = int.Parse(number.Text);

            Boolean check = app_code.users.search(num);

            if (check == true)
            {
                app_code.users.delete(num);
                MessageBox.Show("تم الحذف");
                Close();
            }

            else
            MessageBox.Show("فشل الحذف هذا المستخدم غير موجود");
            
        }


        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
