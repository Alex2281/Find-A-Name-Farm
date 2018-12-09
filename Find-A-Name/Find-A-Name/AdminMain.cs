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
    public partial class AdminMain : Form
    {
        BusinessMetaLayer ap = BusinessMetaLayer.instance();

        List<Task> m_tasks;
        BindingSource m_dg;

        public AdminMain()
        {
            InitializeComponent();
        }
        private void AdminMain_Load(object sender, EventArgs e)
        {
            DateTime selectedDate = Convert.ToDateTime(dtpSelectDay.Text);
            selectedDate.ToShortDateString();
            m_dg = new BindingSource();
            m_tasks = ap.getDaysTasks(selectedDate);
            m_dg.DataSource = m_tasks;
            m_dg.ResetBindings(true);
            this.dgdDailyTasks.DataSource = m_dg.DataSource;
            this.dgdDailyTasks.RowHeadersVisible = false;
            this.dgdDailyTasks.Columns[0].Visible = false;
        }
        private void viewInventoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Inventory n = new Inventory();
            n.ShowDialog();
        }
        private void mainToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }
        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
        private void addEmployeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addEmployee AddEmploy = new addEmployee();
            AddEmploy.ShowDialog();
        }
        private void addVehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addVehicle AddVehicle = new addVehicle();
            AddVehicle.ShowDialog();
        }
        private void addFieldToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addField AddField = new addField();
            AddField.ShowDialog();
        }
        private void addStorageUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addStorageUnit AddStorage = new addStorageUnit();
            AddStorage.ShowDialog();
        }
        private void addCropToolStripMenuItem_Click(object sender, EventArgs e)
        {
            addCrop AddCrop = new addCrop();
            AddCrop.ShowDialog();
        }
        private void vehicleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editVehicle editVeh = new editVehicle();
            editVeh.ShowDialog();
        }
        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            editEmployee EditEmp = new editEmployee();
            EditEmp.ShowDialog();
        }
        private void dgdDailyTasks_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            m_dg = new BindingSource();
            m_tasks = ap.getTasks();
            m_dg.DataSource = m_tasks;
            m_dg.ResetBindings(true);
            this.dgdDailyTasks.DataSource = m_dg.DataSource;
            this.dgdDailyTasks.RowHeadersVisible = false;
            this.dgdDailyTasks.Columns[0].Visible = false;
        }
        private void setTaskToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            setTask SetTask = new setTask();
            SetTask.ShowDialog();
        }
        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
