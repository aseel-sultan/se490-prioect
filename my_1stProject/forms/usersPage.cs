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
            this.Hide();

        }

        private void update_Click(object sender, EventArgs e)
        {
            updatePage update = new updatePage();
            update.Show();
            this.Hide();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            deletePage delete = new deletePage();
            delete.Show();
            this.Hide();

        }
        //back button
        private void button1_Click(object sender, EventArgs e)
        {

             
            mainPage main = new mainPage();
             main.Show();
              this.Hide();
           
            // استخدمت hide  عشان تسكر وتفتح الرئسيسه
           
        }

        private void usersPage_Load(object sender, EventArgs e)
        {
            DataTable dt = app_code.users.selectData();
            dataGridUsers.DataSource = dt;
        }

        

    }
}
