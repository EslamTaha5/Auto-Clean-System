using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clean_System {
    public partial class EmployeeDashboard : Form {
        StaffClass employee = null;
        public EmployeeDashboard(StaffClass staffUser) {
            InitializeComponent();
            employee = staffUser;
            initPages();
            

        }

        private void Employee_tab_DrawItem(object sender, DrawItemEventArgs e) {
            Employee_tab.DrawItem += new DrawItemEventHandler(Employee_tab_DrawItem);
            TabPage tabPage = Employee_tab.TabPages[e.Index];
            Rectangle tabBounds = Employee_tab.GetTabRect(e.Index);

            bool isSelected = (e.Index == Employee_tab.SelectedIndex);

            // Set custom colors and fonts
            Color backColor = isSelected ? Color.LightBlue : Color.LightGray;
            Color textColor = isSelected ? Color.Black : Color.DarkGray;
            Font font = new Font("Aura", isSelected ? 10f : 9f, isSelected ? FontStyle.Bold : FontStyle.Regular);

            using (Brush backgroundBrush = new SolidBrush(backColor))
            using (Brush textBrush = new SolidBrush(textColor)) {
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

        private void btnLogout_Click(object sender, EventArgs e) {
            RoleSelection SelectRole = new RoleSelection();
            SelectRole.Show();
            this.Hide();
        }

        private void initPages() {
            //Profile
            employeeIdTxt.Text = employee.staffID.ToString();
            employeeNameTxt.Text = employee.name;
            employeePaswordTxt.Text = employee.password;
            employeeSalaryTxt.Text = employee.salary.ToString();
            EmployeeBounsTxt.Text = employee.bonus.ToString();


        }
 

        void insertOrderDetail(OrderPage order) {
            try {
                this.ordersTableAdapter.insertOrder(order.customerID, order.employeeID, order.CarName, (int)order.cost, order.discount, (int)order.totalCost);
                this.fKOrderStaffBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(autoCleanDatabaseDataSet);

            } catch (Exception ex) {
                MessageBox.Show($"Error In Order Insert {ex.Message}");
            }
        }

        void insertOrder(OrderPage order) {
            insertCustomer(order);
            object result = this.customerTableAdapter.FindCustomerID(order.customerName, order.customerPhone, order.CarName);
            if (result != null && result != DBNull.Value) {
                order.customerID = Convert.ToInt32(result);
            }
            Console.WriteLine($"Customer ID {order.customerID}");
            insertOrderDetail(order);
        }

        private void addOrderBtn_Click_1(object sender, EventArgs e) {
            OrderPage order = getOrderData();

            if (order == null) {
                MessageBox.Show("Invalid Order Data!");
                return;
            }

            insertOrder(order);
            MessageBox.Show("Order Completed!");
        }
    }
}
