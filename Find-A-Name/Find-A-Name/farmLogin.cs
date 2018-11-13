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
using System.Data.Common;

namespace Find_A_Name
{
    public partial class farmLogin : Form
    {
        private int m_privilage = -1;
        public farmLogin()
        {
            InitializeComponent();

        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ln = BusinessMetaLayer.instance();
            m_privilage = ln.farmLogin(txtUsername.Text, txtPassword.Text);
            //*
            //if(retv = 0)
            //{

            //}
            //else if (retv = 1)
            //{

            //}
            //else if (retv = 2)
            //{

            //}
            //else
            //{

            //}
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void farmLogin_Load(object sender, EventArgs e)
        {
            
            try
            {
                
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
