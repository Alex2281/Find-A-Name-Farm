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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();
            int success;
            success = create.addEmployees(txtFirstname.Text, txtSurname.Text, txtPostcode.Text, txtPhone.Text, txtEmail.Text, txtUsername.Text, txtPassword.Text);

            if (success == 1)
            {
                MessageBox.Show("Account Created");
                txtFirstname.Clear();
                txtSurname.Clear();
                txtUsername.Clear();
                txtPostcode.Clear();
                txtPhone.Clear();
                txtPassword.Clear();
                txtEmail.Clear();
            }
            else
            {
                MessageBox.Show("A Input is Incorrect.");
            }
        }
    }
}
