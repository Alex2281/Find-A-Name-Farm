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
    public partial class LabourerMain : Form
    {
        Employee user = new Employee();
        BindingSource utl;

        public LabourerMain()
        {
            InitializeComponent();

        }
        public LabourerMain(int employeeId)
        {
            InitializeComponent();

            BusinessMetaLayer u = BusinessMetaLayer.instance();

            List<Task> m_tasks;

            user = u.getUserDetails(employeeId);
            this.gbUserDetails.Text = user.Username;
            this.lbvName.Text = user.Name;
            this.lbvAddress.Text = user.Address;
            this.lbvPhoneNumber.Text = user.Phone;
            this.lbvEmailAddress.Text = user.Email;
            utl = new BindingSource();
            m_tasks = u.getUserTasks(employeeId);
            utl.DataSource = m_tasks;
            utl.ResetBindings(true);
            this.dgdUserTasks.DataSource = utl.DataSource;
            this.dgdUserTasks.RowHeadersVisible = false;
            this.dgdUserTasks.Columns[0].Visible = false;
            this.dgdUserTasks.Columns[2].Visible = false;

        }
        private void LabourerPage_Load(object sender, EventArgs e)
        {

        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            this.Hide();
            Login f = new Login();
            f.ShowDialog();
        }
    }
}