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
        SqlConnection con = new SqlConnection();
        public farmLogin()
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\repos\Find-A-Name-Farm\Find-A-Name\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection();
            con.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\repos\Find-A-Name-Farm\Find-A-Name\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30";
            con.Open();
            string userid = txtUsername.Text;
            string password = txtPassword.Text;
            SqlCommand cmd = new SqlCommand("select userid,password from login where userid='" + txtUsername.Text + "'and password='" + txtPassword.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);

            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage");
                System.Diagnostics.Process.Start("");
            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void farmLogin_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=E:\repos\Find-A-Name-Farm\Find-A-Name\DB\LoginDB.mdf;Integrated Security=True;Connect Timeout=30");
            con.Open();
        }
    }
}
