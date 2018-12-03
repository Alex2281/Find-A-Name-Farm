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
    public partial class addCrop : Form
    {
        public addCrop()
        {
            InitializeComponent();
        }

        private void btnAddCrop_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();

            int success;
            String cropName = txtCropName.Text;
            String fertName = txtFertName.Text;
            int cultivationTime = Convert.ToInt32(this.txtCultTime.Text);
            int fertFrequency = Convert.ToInt32(this.txtFertFreq.Text);
            int yieldValue = Convert.ToInt32(this.txtYieldValue.Text);

            success = create.addCrop(txtCropName.Text, cultivationTime, fertFrequency, yieldValue, fertName);

            if (success == 1)
            {
                MessageBox.Show("Crop added");
                txtCropName.Clear();
                txtCultTime.Clear();
                txtFertFreq.Clear();
                txtYieldValue.Clear();
            }
            else
            {
                MessageBox.Show("An input is incorrect");
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
