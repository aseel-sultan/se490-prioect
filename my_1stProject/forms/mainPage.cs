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
    public partial class mainPage : Form
    {
        public mainPage()
        {
            InitializeComponent();
        }
       //اذا تم الضغد على زر اعدادات المستخدمين ينتقل الى صفحة المستخدمين
        private void Usetting_Click(object sender, EventArgs e)
        {
            Close();

            usersPage usersPage = new usersPage();

            usersPage.Show();

        }

       


    }
}
