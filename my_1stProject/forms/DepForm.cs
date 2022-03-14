using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using my_1stProject.app_code;

namespace my_1stProject.forms
{
    public partial class DepForm : Form
    {
        public DepForm()
        {
            InitializeComponent();
        }



        private void DepForm_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            

            
        }

        private void lblItemsetting_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            ItemsSetting i = new ItemsSetting();
            i.Show();
            this.Close();
        }
    }
}
