﻿using System;
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
    public partial class EmployeeList : Form
    {
        List<Employee> m_employees;
        BindingSource m_bs;
        DataSet dataSet = null;

        public EmployeeList()
        {
            InitializeComponent();
            m_bs = new BindingSource();
            m_bs.DataSource = m_employees;
            cmbEmployees.DataSource = m_bs;
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_employees = ml.getEmployees();
            m_bs.DataSource = m_employees;
            m_bs.ResetBindings(false);

            // Fill data grid
            DbConection con = DbFactory.instance();
            con.OpenConnection();
            dataSet = con.getDataSet("Select * from Employees");
            DataTable table = dataSet.Tables[0];
            //FillInTextFields(table, 1);
            //set up the data grid view
            this.dataGridView1.DataSource = table;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (null != dataSet)
            {
                dataSet.AcceptChanges();
            }
        }

        private void EmployeeList_Load(object sender, EventArgs e)
        {

        }

        private void btnTest_Click_1(object sender, EventArgs e)
        {
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_employees = ml.getEmployees();
            m_bs.DataSource = m_employees;
            m_bs.ResetBindings(false);

            // Fill data grid
            DbConection con = DbFactory.instance();
            con.OpenConnection();
            dataSet = con.getDataSet("Select * from Employees");
            DataTable table = dataSet.Tables[0];
            //FillInTextFields(table, 1);
            //set up the data grid view
            this.dataGridView1.DataSource = table;
        }

    }
}
