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
    public partial class editVehicle : Form
    {

        BusinessMetaLayer ml = BusinessMetaLayer.instance();
        List<Vehicle> m_vehicles;
        BindingSource m_ve;
        int rowNum = 1;
        string ID;
        string name;
        string description;
        string status;
        
        

        public editVehicle()
        {
            InitializeComponent();

            m_ve = new BindingSource();
            m_vehicles = ml.getVehicles();
            m_ve.DataSource = m_vehicles;
            m_ve.ResetBindings(false);
            this.dataGridView1.DataSource = m_ve.DataSource;
            cmbStatus.Items.Add("Available");
            cmbStatus.Items.Add("Out of Service");
            cmbStatus.Items.Add("In Repair");

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            rowNum = rowNum + 1;
            for (int col = 0; col < dataGridView1.Rows[rowNum].Cells.Count; col++)
            {
                string result = dataGridView1.Rows[rowNum].Cells[col].Value.ToString();
                if (col == 0)
                {
                    ID = result;
                }
                if (col == 1)
                {
                    name = result;
                }
                if (col == 2)
                {
                    description = result;
                }
                if (col == 3)
                {
                    status = result;
                }
            }
            txtName.Text = name;
            txtDescrip.Text = description;
            cmbStatus.Text = status;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (rowNum <= 0 )
            {
                rowNum = rowNum - 1;

                for (int col= 0; col < dataGridView1.Rows[rowNum].Cells.Count; col++)
                {
                    string result = dataGridView1.Rows[rowNum].Cells[col].Value.ToString();
                    if (col == 0)
                    {
                        ID = result;
                    }
                    if (col == 1)
                    {
                        name = result;
                    }
                    if (col == 2)
                    {
                        description = result;
                    }
                    if (col == 3)
                    {
                        status = result;
                    }
                }
                txtName.Text = name;
                txtDescrip.Text = description;
                cmbStatus.Text = status;
                cmbStatus.SelectedText = status;
            }
            else
            {
                MessageBox.Show("Lower then minimum");
            }




          

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            int success;

            int vehStatusType;
            vehStatusType = 0;
            if (cmbStatus.Text == "Available")
            {
                vehStatusType = 1;
            }
            else if (cmbStatus.Text == "Out of Service")
            {
                vehStatusType = 2;
            }
            else if (cmbStatus.Text == "In Repair")
            {
                vehStatusType = 3;
            }
            else
            {
                MessageBox.Show("Invalid Selection");
            }

            success = ml.EditVehicle(ID, txtName.Text, txtDescrip.Text, vehStatusType );

            if (success == 1)
            {
                MessageBox.Show("Account Created");
                m_ve = new BindingSource();
                m_vehicles = ml.getVehicles();
                m_ve.DataSource = m_vehicles;
                m_ve.ResetBindings(false);
                this.dataGridView1.DataSource = m_ve.DataSource;
                txtName.Clear();
                txtDescrip.Clear();
            }
            else
            {
                MessageBox.Show("A Input is Incorrect.");
            }

        }
    }
}
