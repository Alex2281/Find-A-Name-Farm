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
            this.lblName.Text = user.Name;
            this.lblAddress.Text = user.Address;
            this.lblPhoneNumber.Text = user.Phone;
            this.lblEmailAddress.Text = user.Email;
            utl = new BindingSource();
            m_tasks = u.getUserTasks(employeeId);
            utl.DataSource = m_tasks;
            utl.ResetBindings(true);
            this.dgdUserTasks.DataSource = utl.DataSource;
            this.dgdUserTasks.RowHeadersVisible = false;
            this.dgdUserTasks.Columns[0].Visible = false;


        }
        private void LabourerPage_Load(object sender, EventArgs e)
        {

        }
    }
}