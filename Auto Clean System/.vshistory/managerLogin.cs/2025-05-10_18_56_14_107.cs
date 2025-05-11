using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clean_System
{
    public partial class managerLogin : Form
    {
        public DataSet staffDataSet = new DataSet();
        public managerLogin()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            RoleSelection SelectRole = new RoleSelection();
            SelectRole.Show();
            this.Hide();
        }

        private bool CheckManager() {
            string managerID = txtUsername.Text;
            string password = txtPassword.Text;  

            return true;
        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            CheckManager();
            managerDashboard Manager = new managerDashboard();

            Manager.Show();
            this.Hide();
        }

    }
}
