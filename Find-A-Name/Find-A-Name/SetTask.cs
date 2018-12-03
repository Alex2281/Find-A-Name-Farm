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
    public partial class SetTask : Form
    {
        BusinessMetaLayer tl = BusinessMetaLayer.instance();

        List<Employee> m_employees;
        List<TaskType> m_taskTypes;
        
        BindingSource m_bs;
        BindingSource m_ts;

        public SetTask()
        {
            InitializeComponent();

            //Load Employee Combo Box
            m_bs = new BindingSource();
            m_employees = tl.getEmployees();
            m_bs.DataSource = m_employees;
            cmbEmployees.DataSource = m_bs;
            //Load Times Combo Box
            cmbTimes.Items.Add("06:00");
            cmbTimes.Items.Add("06:30");
            cmbTimes.Items.Add("07:00");
            cmbTimes.Items.Add("07:30");
            cmbTimes.Items.Add("08:00");
            cmbTimes.Items.Add("09:00");
            cmbTimes.Items.Add("11:00");
            cmbTimes.Items.Add("12:00");
            cmbTimes.Items.Add("13:00");
            cmbTimes.Items.Add("14:00");
            cmbTimes.Items.Add("15:00");
            cmbTimes.Items.Add("16:00");
            cmbTimes.Items.Add("17:00");
            cmbTimes.Items.Add("18:00");
            cmbTimes.Items.Add("19:00");
            cmbTimes.Items.Add("20:00");
            //Load Task Type Combo Box
            m_ts = new BindingSource();
            m_taskTypes = tl.getTaskTypes();
            m_ts.DataSource = m_taskTypes;
            cmbTaskTypes.DataSource = m_ts;
        }
    }
}
