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
    public partial class addField : Form
    {
        public addField()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain f = new AdminMain();
            f.ShowDialog();
        }

        private void btnAddField_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();
            int inUse = 0;
            int success;
            int fieldSize = Convert.ToInt32(this.txtFieldSize.Text);
            success = create.addField(txtFieldRef.Text, fieldSize, inUse);

            if (success == 1)
            {
                MessageBox.Show("Field Created");
                txtFieldRef.Clear();
                txtFieldSize.Clear();
            }
            else
            {
                MessageBox.Show("An input is incorrect");
            }


        }
    }
}
