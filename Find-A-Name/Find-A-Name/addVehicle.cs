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
    public partial class addVehicle : Form
    {
        public addVehicle()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain f = new AdminMain();
            f.ShowDialog();
        }

        private void btnAddVeh_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();
            int accessPrivilage;
            if (chboxStatus.Checked == true)
            {
                accessPrivilage = 1;
            }
            else
            {
                accessPrivilage = 2;
            }


            int success;
            success = create.addVehicle(txtType.Text, txtDescription.Text);

            if (success == 0)
            {
                MessageBox.Show("Account Created");
                txtType.Clear();
                txtDescription.Clear();
                chboxStatus.Checked = false;
            }
            else
            {
                MessageBox.Show("A Input is Incorrect.");
            }
        }
    }
}
