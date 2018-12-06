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
    public partial class Inventory : Form
    {
        List<Employee> m_employees;
        List<Vehicle> m_vehicles;
        List<Field> m_fields;
        List<Crop> m_crops;
        List<Fertiliser> m_fertilisers;
        List<StorageUnit> m_storageUnits;
        BindingSource m_bs;

        public Inventory()
        {
            InitializeComponent();
            m_bs = new BindingSource();
        }
        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }
        private void lstEmployees_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_employees = ml.getEmployees();
            m_bs.DataSource = m_employees;
            m_bs.ResetBindings(false);
            this.dataGridView1.DataSource = m_bs.DataSource;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].Visible = false;
        }
        private void lstVehicles_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_vehicles = ml.getVehicles();
            m_bs.DataSource = m_vehicles;
            m_bs.ResetBindings(false);
            this.dataGridView1.DataSource = m_bs.DataSource;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].Visible = false;
        }
        private void lstFields_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_fields = ml.getFields();
            m_bs.DataSource = m_fields;
            m_bs.ResetBindings(false);
            this.dataGridView1.DataSource = m_bs.DataSource;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].Visible = false;
        }
        private void lstCrops_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_crops = ml.getCrops();
            m_bs.DataSource = m_crops;
            m_bs.ResetBindings(false);
            this.dataGridView1.DataSource = m_bs.DataSource;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].Visible = false;
        }
        private void btnFertiliser_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_fertilisers = ml.getFertilisers();
            m_bs.DataSource = m_fertilisers;
            m_bs.ResetBindings(false);
            this.dataGridView1.DataSource = m_bs.DataSource;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].Visible = false;
        }
        private void lstStorage_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_storageUnits = ml.getStorageUnits();
            m_bs.DataSource = m_storageUnits;
            m_bs.ResetBindings(false);
            this.dataGridView1.DataSource = m_bs.DataSource;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Columns[0].Visible = false;
        }
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Hide();
            AdminMain f = new AdminMain();
            f.ShowDialog();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
