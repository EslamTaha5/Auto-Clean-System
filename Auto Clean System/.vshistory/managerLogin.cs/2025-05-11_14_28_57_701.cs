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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

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
                    staffUser = new StaffClass();
                    staffUser.staffID = username;
                    staffUser.password = pass;
                    staffUser.isManager = 1;
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
        private void btnLogin_Click(object sender, EventArgs e)
        {

            Console.WriteLine("Log In As Manager!");
            long ID = CheckManager();
            if (ID == -1) {
                MessageBox.Show("Invalid UserName Or Password");
                return;
            }
            setUserName(ID);
            Console.WriteLine(staffUser);
           //    Console.WriteLine(name);
            MessageBox.Show("Logged In Successfully!");

            managerDashboard Manager = new managerDashboard(staffUser);

            Manager.Show();
            this.Hide();
        }

        private void staffBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.staffBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoCleanDatabaseDataSet);

        }

        private void managerLogin_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.autoCleanDatabaseDataSet.Staff);

        }
    }
}
