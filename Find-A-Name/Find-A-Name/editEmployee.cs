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
    public partial class editEmployee : Form
    {
        List<Employee> m_employees;
        BindingSource m_bs;

        public  editEmployee()
        {
            InitializeComponent();
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_employees = ml.getEmployees();
            m_bs.DataSource = m_employees;
            m_bs.ResetBindings(false);
            this.dataGridView1.DataSource = m_bs.DataSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
