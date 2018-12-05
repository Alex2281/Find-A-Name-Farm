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
    public partial class setTask : Form
    {
        BusinessMetaLayer tl = BusinessMetaLayer.instance();

        List<Employee> m_employees;
        BindingSource m_em;

        List<TaskType> m_taskTypes;
        BindingSource m_tt;

        List<TaskStatus> taskStatuses;
        BindingSource m_ts;

        List<Crop> m_crops;
        BindingSource m_cr;

        List<Field> m_fields;
        BindingSource m_fd;

        List<Vehicle> m_vehicles;
        BindingSource m_ve;

        List<StorageUnit> m_storageUnits;
        BindingSource m_su;

        public setTask()
        {
            InitializeComponent();

            //dtTaskDate.Format = DateTimePickerFormat.Custom;
            //dtTaskDate.CustomFormat = "dd-MM-yyyy";

            //Load Employee Combo Box
            m_em = new BindingSource();
            m_employees = tl.getEmployees();
            m_em.DataSource = m_employees;
            cmbEmployees.DataSource = m_em;
            //Load Times Combo Box
            cmbTimes.Items.Add("0600");
            cmbTimes.Items.Add("06/30");
            cmbTimes.Items.Add("07:00:00");
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
            m_tt = new BindingSource();
            m_taskTypes = tl.getTaskTypes();
            
            m_tt.DataSource = m_taskTypes;
            cmbTaskTypes.DisplayMember = "Name";
            cmbTaskTypes.ValueMember = "Id";
            cmbTaskTypes.DataSource = m_tt;
            //Load Task Status Combo Box
            m_cr = new BindingSource();
            m_crops = tl.getCrops();
            m_cr.DataSource = m_crops;
            cmbCrops.DataSource = m_cr;
            //Load Field Combo Box
            m_fd = new BindingSource();
            m_fields = tl.getFields();
            m_fd.DataSource = m_fields;
            cmbFields.DataSource = m_fd;
            //Load Vehicle Combo Box
            m_ve = new BindingSource();
            m_vehicles = tl.getVehicles();
            m_ve.DataSource = m_vehicles;
            cmbVehicles.DataSource = m_ve;
            //Load Storage Unit Combo Box
            m_su = new BindingSource();
            m_storageUnits = tl.getStorageUnits();
            m_su.DataSource = m_storageUnits;
            cmbStorageUnit.DataSource = m_storageUnits;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();
            //DateTime taskDate = dtTaskDate;
            int success;
            success = create.setTask(dtTaskDate.Value.ToString("dd/MM/yyyy"), cmbTimes.Text, cmbEmployees.Text, cmbTaskTypes.ValueMember, cmbCrops.Text, cmbFields.Text, cmbVehicles.Text, cmbStorageUnit.ValueMember);

            if (success == 1)
            {
                MessageBox.Show("Task Created");
                
            }
            else
            {
                MessageBox.Show("A Input is Incorrect.");
            }
        }
    }
}
