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
        BusinessMetaLayer bml = BusinessMetaLayer.instance();

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
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_vehicles = ml.getVehicles();
            m_ve.DataSource = m_vehicles;
            m_ve.ResetBindings(false);
            this.dataGridView1.DataSource = m_ve.DataSource;

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            rowNum = rowNum + 1;
            for (int col = 0; col < dataGridView1.Rows[rowNum].Cells.Count; col++)
            {
                string result = dataGridView1.Rows[rowNum].Cells[col].Value.ToString();
                MessageBox.Show(result);
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
            txtStatus.Text = status;
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (rowNum <= 0 )
            {
                rowNum = rowNum - 1;

                for (int col= 0; col < dataGridView1.Rows[rowNum].Cells.Count; col++)
                {
                    string result = dataGridView1.Rows[rowNum].Cells[col].Value.ToString();
                    MessageBox.Show(result);
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
                txtStatus.Text = status;
            }
            else
            {
                MessageBox.Show("Lower then minimum");
            }


          

        }
    }
}
