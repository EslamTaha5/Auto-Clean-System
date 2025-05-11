using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static Auto_Clean_System.AutoCleanDatabaseDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters;

namespace Auto_Clean_System {
    public partial class EmployeeLogin : Form {
        StaffClass staffUser = new StaffClass();
        public EmployeeLogin() {
            InitializeComponent();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e) {

        }
        private long CheckManager() {
            if (!long.TryParse(txtUsername.Text, out long username)) {
                return -1;
            }
            Console.WriteLine("Username is a number");
            try {
                string pass = txtPassword.Text;
                int manager = 0;
                Console.WriteLine($"{username} {pass}");
                // Execute the scalar query to get the average salary
                   
                object result = Program.StaffAdapter.FindStaff(username, pass, manager);

                // findUser returns integer the number of users found with these credentials
                if (result != null && result != DBNull.Value) {
                    decimal users = Convert.ToDecimal(result);


                    if (users == 0) return -1;
                    staffUser = new StaffClass();
                    staffUser.staffID = username;
                    staffUser.password = pass;
                    staffUser.isManager = 0;
                    return username;
                } else {
                    return -1;
                }
            } catch (Exception ex) {
                MessageBox.Show($"Error find user {ex.Message}");
                return -1;
            }
        }

        string getUserName(long ID) {
            object result = Program.StaffAdapter.FindStaffName(ID);

            return Convert.ToString(result);
        }
        void setUserName(long ID) {
            string name = getUserName(ID);
            staffUser.name = name;
        }
        private void btnLogin_Click(object sender, EventArgs e) {

            EmployeeDashboard Employee = new EmployeeDashboard();
            Employee.Show();
            this.Hide();
        }

        private void btnBack_Click(object sender, EventArgs e) {
            RoleSelection SelectRole = new RoleSelection();
            SelectRole.Show();
            this.Hide();
        }
    }
}
