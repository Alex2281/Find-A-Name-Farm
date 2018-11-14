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
    public partial class Login : Form
    {
        private int m_privilage = -1;
        public Login()
        {
            InitializeComponent();

        }
        private void farmLogin_Load(object sender, EventArgs e)
        {
            
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            BusinessMetaLayer ln = BusinessMetaLayer.instance();
            
            m_privilage = ln.farmLogin(txtUsername.Text, txtPassword.Text);
            
            if (m_privilage == 0)
            {
                this.Hide();
                AdminMain n = new AdminMain();
                n.ShowDialog();
            }
            else if (m_privilage == 1)
            {
                MessageBox.Show("User is a Worker");
            }
            else if (m_privilage == -1)
            {
                MessageBox.Show("Please Enter a valid 'Username' & 'Password' in the fields provided!");
            }
            else
            {
                MessageBox.Show("Username / password combimation incorrect");
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        

        private void txtUsername_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }
    }
}
