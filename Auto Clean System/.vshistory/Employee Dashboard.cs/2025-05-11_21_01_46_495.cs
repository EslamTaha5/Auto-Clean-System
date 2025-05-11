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
        bool checkData() {
            Console.WriteLine($"Order Details:\n" +
                $"Car: {txtCarOrder.Text}\n" +
                $"Cost: {txtCostOrder.Text}\n" +
                $"Customer Name: {txtCustomerNameOrder.Text}\n" +
                $"Employee Name: {txtEmployeeNameOrder.Text}\n" +
                $"Phone: {txtPhoneOrder.Text}\n" +
                $"Service: {combServiceNameOrder.Text}\n" +
                $"Discount: {txtDiscountOrder.Text}");
            if (txtCarOrder.Text.Length == 0 ||
                txtCostOrder.Text.Length == 0 ||
                txtCustomerNameOrder.Text.Length == 0 ||
                txtEmployeeNameOrder.Text.Length == 0 ||
                txtPhoneOrder.Text.Length == 0 ||
                combServiceNameOrder.Text.Length == 0 ||
                combServiceNameOrder.SelectedIndex == -1)
                return false;

            Console.WriteLine("All Values Are Set");
            if (!decimal.TryParse(txtPhoneOrder.Text, out decimal tmpPhone)) return false;
            if (!decimal.TryParse(txtDiscountOrder.Text, out decimal tmpDiscount)) return false;
            return true;
        }

        OrderPage getOrderData() {
            if (!checkData()) {

                return null;
            }
            OrderPage orderPage = new OrderPage();
            Console.WriteLine(combServiceNameOrder.SelectedValue.ToString());

            orderPage.ServiceName = combServiceNameOrder.SelectedValue.ToString();
            orderPage.customerName = txtCustomerNameOrder.Text;
            orderPage.employeeName = txtEmployeeNameOrder.Text;
            orderPage.CarName = txtCarOrder.Text;
            orderPage.customerPhone = long.Parse(txtPhoneOrder.Text);
            orderPage.cost = decimal.Parse(txtCostOrder.Text);
            orderPage.discount = decimal.Parse(txtDiscountOrder.Text);
            orderPage.calculateTotal();
            orderPage.employeeID = staffUser.staffID;
            return orderPage;
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

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoCleanDatabaseDataSet);

        }

        private void EmployeeDashboard_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);

        }
    }
}
