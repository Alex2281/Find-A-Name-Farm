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
    public partial class addTask : Form
    {
        public addTask()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();
            

            int success;
            String taskType = txtTaskType.Text;
            String taskDescription = txtTaskDesc.Text;
            success = create.addTaskType(txtTaskType.Text, txtTaskDesc.Text);

            if (success == 1)
            {
                MessageBox.Show("Task Created");
                txtTaskDesc.Clear();
                txtTaskType.Clear();
            }
            else
            {
                MessageBox.Show("An input is correct");
            }
        }
    }
}
