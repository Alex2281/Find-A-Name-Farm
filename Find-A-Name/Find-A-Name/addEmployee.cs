using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Find_A_Name
{
    public partial class addEmployee : Form
    {
        public addEmployee()
        {
            InitializeComponent();
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();

        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }
    }
}
