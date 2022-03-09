using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DepartmentForm.App_Code;

namespace DepartmentForm.UI
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
            

            AddDep fdep = new AddDep();
            fdep.Show();
            DepForm fd = new DepForm();
            fd.Hide();
        }
    }
}
