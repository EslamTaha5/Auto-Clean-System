using Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clean_System
{
    public partial class managerDashboard : Form
    {
        StaffClass staffUser = null;
        public managerDashboard(StaffClass staffUser)
        {
            InitializeComponent();
            this.staffUser = staffUser;
            fillData();


        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e)
        {
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            bool isSelected = (e.Index == tabControl.SelectedIndex);

            // Set custom colors and fonts
            Color backColor = isSelected ? Color.LightBlue : Color.LightGray;
            Color textColor = isSelected ? Color.Black : Color.DarkGray;
            Font font = new Font("Aura", isSelected ? 10f : 9f, isSelected ? FontStyle.Bold : FontStyle.Regular);

            using (Brush backgroundBrush = new SolidBrush(backColor))
            using (Brush textBrush = new SolidBrush(textColor))
            {
                // Fill the background
                e.Graphics.FillRectangle(backgroundBrush, tabBounds);

                // Center the text
                StringFormat sf = new StringFormat();
                sf.Alignment = StringAlignment.Center;
                sf.LineAlignment = StringAlignment.Center;

                // Draw tab text
                e.Graphics.DrawString(tabPage.Text, font, textBrush, tabBounds, sf);
            }
        }
        void fillData() {
            managerUsername.Text = staffUser.name;
            managerId.Text = staffUser.staffID.ToString();
            managerPassword.Text = staffUser.password;
            
        }

        private void managerDashboard_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.autoCleanDatabaseDataSet.Orders);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.autoCleanDatabaseDataSet.Staff);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);

        }

        private void showEmployeesToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.staffTableAdapter.showEmployees(this.autoCleanDatabaseDataSet.Staff);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        StaffClass checkUser() {
            if(!long.TryParse(employeeId.Text, out long userID)) {
                MessageBox.Show("Invalid ID");
                return null;
            }
            if (!int.TryParse(employeeBonus.Text, out int userBonus)) {
                MessageBox.Show("Invalid Bonus");
                return null;
            }
            if(!int.TryParse(employeeSalary.Text, out int userSalary)) {
                MessageBox.Show("Invalid Salary");
                return null;
            }

            staffUser = new StaffClass();
            string name = employeeName.Text;
            string password = employeePassword.Text;
            if(password.Length == 0) {
                MessageBox.Show("Invalid Password");
                return null;
            }
            StaffClass user = new StaffClass(name, userID, userSalary, userBonus, password, 0);
            return user;
        }
        void insertIntoDataBase() {
            Program.StaffAdapter.insertEmployee(staffUser.staffID, staffUser.name, staffUser.password, staffUser.salary, staffUser.bonus, staffUser.isManager);
        }
        private void btnCreate_Click(object sender, EventArgs e) {
            staffUser = checkUser();
            
            if (staffUser == null){
                return;
            }

            insertIntoDataBase();


        }
    }
}
