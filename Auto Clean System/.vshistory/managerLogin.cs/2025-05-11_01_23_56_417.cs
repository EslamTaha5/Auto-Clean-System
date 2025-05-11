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
            if (!long.TryParse(txtUsername.Text, out var username)) {
                return false;
            }
            Console.WriteLine("Username is a number");
            try {
                string pass = txtPassword.Text;
                int manager = 1;
                Console.WriteLine($"{username} {pass}");
                // Execute the scalar query to get the average salary
                object result = this.staffTableAdapter.FindByID();

                // findUser returns integer the number of users found with these credentials
                if (result != null && result != DBNull.Value) {
                    Console.WriteLine($"result : {result}");
                    decimal users = Convert.ToDecimal(result);
                    Console.WriteLine(users);
                    if (users == 0) return false;
                    return true;
                } else {
                    return false;
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error find user {ex.Message}");
                return false;
            }

        }
        private void btnLogin_Click(object sender, EventArgs e)
        {
        
            Console.WriteLine("Log In As Manager!");

            if (!CheckManager()) {
                MessageBox.Show("Invalid UserName Or Password");
                return;
            }
            MessageBox.Show("Logged In Successfully!");

            managerDashboard Manager = new managerDashboard();

            Manager.Show();
            this.Hide();
        }

    }
}
