using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DepartmentForm.UI
{
    public partial class AddDep : Form
    {
        public AddDep()
        {
            InitializeComponent();
        }

        private void lblDepname_Click(object sender, EventArgs e)
        {

        }

        private void btnFun_Click(object sender, EventArgs e)
        {
            
            App_Code.Departments.Insert(txtDepNa.Text);
            MessageFuns mes = new MessageFuns();
            mes.Show();


        }
    }
}
