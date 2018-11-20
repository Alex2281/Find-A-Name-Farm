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
        public AdminMain()
        {
            InitializeComponent();
        }
        private void AdminMain_Load(object sender, EventArgs e)
        {

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

        private void deleteItemToolStripMenuItem_Click(object sender, EventArgs e)
        {

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
    }
}
