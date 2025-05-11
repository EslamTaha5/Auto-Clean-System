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
using static Auto_Clean_System.AutoCleanDatabaseDataSet;

namespace Auto_Clean_System
{
    public partial class managerLogin : Form
    {
        StaffClass staffUser = null;

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

        private long CheckManager() {
            if (!long.TryParse(txtUsername.Text, out long username)) {
                return -1;
            }
            Console.WriteLine("Username is a number");
            try {
                string pass = txtPassword.Text;
                int manager = 1;
                Console.WriteLine($"{username} {pass}");
                // Execute the scalar query to get the average salary
                object result = Program.StaffAdapter.FindStaff(username, pass, manager);

                // findUser returns integer the number of users found with these credentials
                if (result != null && result != DBNull.Value) {
                    decimal users = Convert.ToDecimal(result);
                    if (users == 0) return -1;
                    return username;
                } else {
                    return -1;
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error find user {ex.Message}");
                return -1;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Log In As Manager!");
            long ID = CheckManager();
            if (ID == -1) {
                MessageBox.Show("Invalid UserName Or Password");
                return;
            }
            var result = Program.AppDataSet.Staff.FindByStaffID(ID);
            string name = result.NAME.ToString();
            Console.WriteLine(name);
            MessageBox.Show("Logged In Successfully!");

            managerDashboard Manager = new managerDashboard();

            Manager.Show();
            this.Hide();
        }

    }
}
