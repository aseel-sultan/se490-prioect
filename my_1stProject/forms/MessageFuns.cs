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
    public partial class MessageFuns : Form
    {
        public MessageFuns()
        {
            InitializeComponent();
        }

        private void btnExist_Click(object sender, EventArgs e)
        {
            MessageFuns m = new MessageFuns();
            m.Hide();
        }
    }
}
