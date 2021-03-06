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
    public partial class addVehicle : Form
    {
        public addVehicle()
        {
            InitializeComponent();
            cmbVehStatus.Items.Add("Available");
            cmbVehStatus.Items.Add("Out of Service");
            cmbVehStatus.Items.Add("In Repair");
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
            string cmbResult;
            int accessPrivilage = 1;
            int success;
            cmbResult = cmbVehStatus.SelectedItem.ToString();

            if (cmbResult == "Available")
            {
                accessPrivilage = 1;
            }
            else if (cmbResult == "Out of Service")
            {
                accessPrivilage = 2;
            }
            else if (cmbResult == "In Repair")
            {
                accessPrivilage = 3;
            }
            else
            {
                MessageBox.Show("Status is Incorrect");
            }

            if (txtDescription.Text == string.Empty)
            {
                MessageBox.Show("Description is Empty");
            }
            else if (txtType.Text == string.Empty)
            {
                MessageBox.Show("Type of Vehcile is Empty");
            }
            else
            {
                success = create.addVehicle(txtType.Text, txtDescription.Text, accessPrivilage);

                if (success == 1)
                {
                    MessageBox.Show("Account Created");
                    txtType.Clear();
                    txtDescription.Clear();
                }
                else
                {
                    MessageBox.Show("A Input is Incorrect.");
                }
            }

        }
    }
}
