using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentForm.UI;

namespace DepartmentForm
{
    public partial class ItemsSetting : Form
    {
        public ItemsSetting()
        {
            InitializeComponent();
        }

        private void lblItemsetting_Click(object sender, EventArgs e)
        {

        }

        private void btnDeps_Click(object sender, EventArgs e)
        {
            DepForm fdep = new DepForm();
            fdep.Show();
            ItemsSetting fitem = new ItemsSetting();
            fitem.Hide();
            

        }

        private void label1_Click(object sender, EventArgs e)
        {


        }

        
    }
}
