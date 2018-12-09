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
    public partial class addStorageUnit : Form
    {
        public addStorageUnit()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer asu = BusinessMetaLayer.instance();
            string storageUnitReference;
            int storageUnitCapacity;
            int storageCurrent = 0;
            int storedCrop = 1;
            int success;

            storageUnitReference = txtStorageUnitReference.Text;
            storageUnitCapacity = Convert.ToInt32(txtStorageUnitCapacity.Text);
            success = asu.addStorageUnit(storageUnitReference, storageUnitCapacity, storageCurrent, storedCrop);

            if (success == 1)
            {
                MessageBox.Show("Task Created");
                txtStorageUnitReference.Clear();
                txtStorageUnitCapacity.Clear();
            }
            else
            {
                MessageBox.Show("An input is correct");
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
