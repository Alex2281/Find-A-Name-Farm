using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.OleDb;
using System.Data.SqlClient;

namespace Find_A_Name
{
    public partial class farmLogin : Form
    {
        private OleDbConnection connection = new OleDbConnection();
        public farmLogin()
        {

            InitializeComponent();
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;
Persist Security Info=False;";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            connection.Open();
            OleDbCommand command = new OleDbCommand();
            command.Connection = connection;
            command.CommandText = "select * from Employees where userName='"+ txtUsername.Text + "' and password='" + txtPassword.Text + "'";


            OleDbDataReader reader = command.ExecuteReader();
            int count = 0;
            while(reader.Read())
            {
                count = count + 1;
            }
            if(count == 1)
            {
                MessageBox.Show("Username and password is correct");
            }
            else if(count > 1)
            {
                MessageBox.Show("Duplicate username and password");

            }
            else
            {
                MessageBox.Show("Username and password is not correct");
            }

            connection.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void farmLogin_Load(object sender, EventArgs e)
        {
            
            try
            {
                
                connection.Open();
                checkConnection.Text = "Connection successful";
                connection.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error " + ex);
            }
        }

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
