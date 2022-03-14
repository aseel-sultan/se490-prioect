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
    public partial class usersPage : Form
    {
        public usersPage()
        {
            InitializeComponent();
        }

        private void add_Click(object sender, EventArgs e)
        {
            addUser add = new addUser();
            add.Show();
        }

        private void update_Click(object sender, EventArgs e)
        {
            updatePage update = new updatePage();
            update.Show();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deletePage delete = new deletePage();
            delete.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            // في مشكلة ان لما درت عرض هكي قعدت شاشة اليوزرس ماتسكرش 
         
           //ولما درت كلوز بعدها وجربت حتى قبلها قعدت تسكر وماتعرضش 
            mainPage main = new mainPage();
             main.Show();
              this.Hide();
           
            // استخدمت hide  عشان تسكر وتفتح اللي بعدها
           
        }

    }
}
