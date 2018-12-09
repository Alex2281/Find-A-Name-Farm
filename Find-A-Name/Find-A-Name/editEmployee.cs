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
    public partial class editEmployee : Form
    {

        
        BusinessMetaLayer ml = BusinessMetaLayer.instance();
        List<Employee> m_employees;
        BindingSource m_bs;

        String ID;
        int rowNum = 1;
        string firstName;
        string lastName;
        string userName;
        string password;
        string email;
        string postcode;
        string phoneNumber;
        int privilege;


        public editEmployee()
        {
            InitializeComponent();
            m_bs = new BindingSource();
            BusinessMetaLayer ml = BusinessMetaLayer.instance();
            m_employees = ml.getEmployees();
            m_bs.DataSource = m_employees;
            m_bs.ResetBindings(false);
            this.dataEmployee.DataSource = m_bs.DataSource;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEdEmpNext_Click(object sender, EventArgs e)
        {
            rowNum = rowNum + 1;

            for (int i = 0; i < dataEmployee.Rows[rowNum].Cells.Count; i++)
            {
                string result = dataEmployee.Rows[rowNum].Cells[i].Value.ToString();
                MessageBox.Show(result);

                if(i == 0)
                {
                    firstName = result;
                }
                if(i == 1)
                {
                    lastName = result;
                }
                if(i == 2)
                {
                    userName = result;
                }
                if(i == 3)
                {
                    password = result;
                }
                if(i == 4)
                {
                    email = result;
                }
                if(i== 5)
                {
                    postcode = result;
                }
                if(i == 6)
                {
                    phoneNumber = result;
                }
            }

            txtEdEmpFirstName.Text = firstName;
            txtEdEmpSurname.Text = lastName;
            txtEdEmpUsern.Text = userName;
            txtEdEmpPass.Text = password;
            txtEdEmpEmail.Text = email;
            txtEdEmpPost.Text = postcode;
            txtEdEmpPhone.Text = phoneNumber;
        }

        private void btnEditEmpPrev_Click(object sender, EventArgs e)
        {
            if (rowNum <= 0)
            {
                rowNum = rowNum - 1;

                for(int i = 0; i < dataEmployee.Rows[rowNum].Cells.Count; i++)
                {
                    string result = dataEmployee.Rows[rowNum].Cells[i].Value.ToString();
                    MessageBox.Show(result);

                    if(i == 0)
                    {
                        firstName = result;
                    }
                    if(i == 1)
                    {
                        lastName = result;
                    }
                    if(i == 2)
                    {
                        userName = result;
                    }
                    if(i == 3)
                    {
                        password = result;
                    }
                    if(i == 4)
                    {
                        email = result;
                    }
                    if(i == 5)
                    {
                        postcode = result;
                    }
                    if(i == 6)
                    {
                        phoneNumber = result;
                    }
                    
                }
                txtEdEmpEmail.Text = email;
                txtEdEmpFirstName.Text = firstName;
                txtEdEmpSurname.Text = lastName;
                txtEdEmpPass.Text = password;
                txtEdEmpPhone.Text = phoneNumber;
                txtEdEmpPost.Text = postcode;
                txtEdEmpUsern.Text = userName;
            }
            else
            {
                MessageBox.Show("Lower than minimum");
            }



        }

        private void btnEditEmp_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer create = BusinessMetaLayer.instance();
            int success;

            String privilege;

            if(cboxEdPrivilege.Checked == true)
            {
                privilege = "Yes";
            }
            else
            {
                privilege = "No";
            }

            String firstName = txtEdEmpFirstName.Text;
            String lastName = txtEdEmpSurname.Text;
            String userName = txtEdEmpUsern.Text;
            String password = txtEdEmpPass.Text;
            String email = txtEdEmpEmail.Text;
            String postcode = txtEdEmpPost.Text;
            String phoneNumber = txtEdEmpPhone.Text;

            success = ml.EditEmployee(ID, firstName, lastName, userName, password, email, postcode, phoneNumber, privilege);

            if(success == 1)
            {
                MessageBox.Show("Account edited");
                m_bs = new BindingSource();
                m_employees = ml.getEmployees();
                m_bs.DataSource = m_employees;
                m_bs.ResetBindings(false);
                this.dataEmployee.DataSource = m_bs.DataSource;
                txtEdEmpFirstName.Clear();
                txtEdEmpSurname.Clear();
                txtEdEmpUsern.Clear();
                txtEdEmpPass.Clear();
                txtEdEmpEmail.Clear();
                txtEdEmpPost.Clear();
                txtEdEmpPhone.Clear();
                cboxEdPrivilege.Checked = false;
            }
        }
    }
}
