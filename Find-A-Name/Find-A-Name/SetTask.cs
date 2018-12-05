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

        List<Task> m_tasks;
        BindingSource m_dg;

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
            //Load Task Type Combo Box
            m_tt = new BindingSource();
            m_taskTypes = tl.getTaskTypes();
            m_tt.DataSource = m_taskTypes;
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
            
            m_dg = new BindingSource();
            m_tasks = tl.getTasks();
            m_dg.DataSource = m_tasks;
            m_dg.ResetBindings(true);
            this.dgdTasksList.DataSource = m_dg.DataSource;
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            DateTime taskDate = dtTaskDate.Value;
            Employee selectedEmployee = (Employee)cmbEmployees.SelectedItem;
            int employeeId = selectedEmployee.Id;       
            TaskType selectedTaskType = (TaskType)cmbTaskTypes.SelectedItem;
            int taskTypeId = selectedTaskType.Id;
            Crop selectedCrop = (Crop)cmbCrops.SelectedItem;
            int cropId = selectedCrop.Id;
            Field selectedField = (Field)cmbFields.SelectedItem;
            int fieldId = selectedField.Id;
            Vehicle selectedVehicle = (Vehicle)cmbVehicles.SelectedItem;
            int vehicleId = selectedVehicle.Id;
            StorageUnit selectedStorageUnit = (StorageUnit)cmbStorageUnit.SelectedItem;
            int storageUnitId = selectedStorageUnit.Id;

            BusinessMetaLayer create = BusinessMetaLayer.instance();
            //DateTime taskDate = dtTaskDate;
            int success;

            success = create.setTask(taskDate, employeeId, taskTypeId, cropId, fieldId, vehicleId, storageUnitId);

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
