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
        private int[] user = new int[2];
        
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
            
            user = ln.farmLogin(Tester.Text, txtPassword.Text);
            
            if (user[0] == 0)
            {
                this.Hide();
                AdminMain n = new AdminMain();
                n.ShowDialog();
            }
            else if (user[0] == 1)
            {
                this.Hide();
                LabourerMain n = new LabourerMain(user[1]);
                n.ShowDialog();
            }
            else if (user[0] == -1)
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
