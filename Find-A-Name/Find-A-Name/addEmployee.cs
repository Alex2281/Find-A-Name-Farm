﻿using System;
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
            string accessPrivilage;
            if (cboxPrivilege.Checked == true)
            {
                accessPrivilage = "Yes";
            }
            else
            {
                accessPrivilage = "No";
            }

            string password = txtPassword.Text;
            int success;
            success = create.addEmployee(txtFirstname.Text, txtSurname.Text, txtPostcode.Text, txtPhone.Text, txtEmail.Text, txtUsername.Text, password, accessPrivilage);

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
                cboxPrivilege.Checked = false;
            }
            else
            {
                MessageBox.Show("A Input is Incorrect.");
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain f = new AdminMain();
            f.ShowDialog();
        }
    }
}
