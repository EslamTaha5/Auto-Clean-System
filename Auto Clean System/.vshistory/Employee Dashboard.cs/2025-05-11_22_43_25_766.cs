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
            txtEmployeeNameOrder.Text = employee.name;
            loadServicesIntoComboBox();
        }

        private void loadServicesIntoComboBox() {
            try {
                // Clear and reload the data source
                autoCleanDatabaseDataSet.Services.Clear();
                servicesTableAdapter.Fill(autoCleanDatabaseDataSet.Services);

                // Bind the ComboBox
                combServiceNameOrder.DataSource = autoCleanDatabaseDataSet.Services;
                combServiceNameOrder.DisplayMember = "ServiceName";
                combServiceNameOrder.ValueMember = "ServiceID";
                combServiceNameOrder.SelectedIndex = -1;

            } catch (Exception ex) {
                MessageBox.Show($"Error loading services: {ex.Message}");
            }
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
            if (txtPhoneOrder.Text.Length == 0 ||
                txtCostOrder.Text.Length == 0 ||
                txtCustomerNameOrder.Text.Length == 0 ||
                txtEmployeeNameOrder.Text.Length == 0 ||
                txtCarOrder.Text.Length == 0 ||
                combServiceNameOrder.Text.Length == 0 ||
                combServiceNameOrder.SelectedIndex == -1)
                return false;

            Console.WriteLine("All Values Are Set");
            if (!decimal.TryParse(txtPhoneOrder.Text, out decimal tmpPhone)) return false;
            if (!decimal.TryParse(txtDiscountOrder.Text, out decimal tmpDiscount)) return false;
            if(tmpDiscount < 0 || tmpDiscount > 100) return false;
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
            orderPage.CarName = txtPhoneOrder.Text;
            orderPage.customerPhone = long.Parse(txtCarOrder.Text);
            orderPage.cost = decimal.Parse(txtCostOrder.Text);
            orderPage.discount = decimal.Parse(txtDiscountOrder.Text);
            orderPage.calculateTotal();
            orderPage.employeeID = employee.staffID;
            return orderPage;
        }

        void insertCustomer(OrderPage order) {
            try {
                // Explicitly convert Car to string

                object result = this.customerTableAdapter.FindCustomer(order.CarName, order.customerPhone, order.CarName);

                // findUser returns integer the number of users found with these credentials
                if (result != null && result != DBNull.Value) {
                    decimal users = Convert.ToDecimal(result);
                    if (users != 0) return;
                }
                this.customerTableAdapter.insertCustomer(order.customerName, order.customerPhone, order.CarName);
                this.customerBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(autoCleanDatabaseDataSet);
                this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);

            } catch (Exception ex) {
                MessageBox.Show($"Error inserting customer: {ex.Message}");
            }
        }


        void insertOrderDetail(OrderPage order) {
            try {
                
                this.ordersTableAdapter.insertOrder(order.customerID, order.employeeID, order.CarName, (int)order.cost, order.discount, (int)order.totalCost);
                this.ordersBindingSource.EndEdit();
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
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.autoCleanDatabaseDataSet.Orders);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.showEmployeeCustomers(autoCleanDatabaseDataSet.Customer,employee.staffID);

        }

        private void combServiceNameOrder_SelectedIndexChanged(object sender, EventArgs e) {
            // Check if an item is actually selected
            if (combServiceNameOrder.SelectedItem == null || combServiceNameOrder.SelectedIndex < 0) {
                txtCostOrder.Text = "0.00";
                totalCostDiscount.Text = "0.00";
                return;
            }

            try {
                // Get the selected row from the data source
                DataRowView selectedRow = (DataRowView)combServiceNameOrder.SelectedItem;

                // Get the cost from the StandardCost column
                decimal serviceCost = Convert.ToDecimal(selectedRow["StandardCost"]);

                // Update the cost textbox
                txtCostOrder.Text = serviceCost.ToString("F2"); // Format with 2 decimal places

                // Optional: Auto-calculate total if you have discount logic
                CalculateTotal();

            } catch (Exception ex) {
                MessageBox.Show($"Error getting service cost: {ex.Message}");
                txtCostOrder.Text = "0.00";
            }
        }
        private void CalculateTotal() {
            decimal total = 0;
            if (decimal.TryParse(txtCostOrder.Text, out decimal cost) &&
                decimal.TryParse(txtDiscountOrder.Text, out decimal discount)) {
                total = cost - (cost * discount / 100);
                // Update your total field if you have one
            }
            totalCostDiscount.Text = total.ToString();
        }

        private void tabProfile_Click(object sender, EventArgs e) {

        }

        private void txtDiscountOrder_TextChanged(object sender, EventArgs e) {
            CalculateTotal();
        }

        private void customerDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }
            DataGridViewRow selRow = customerDataGridView.Rows[e.RowIndex];

            try {
                customerName.Text = selRow.Cells["customerNameRow"].Value.ToString();
                customerId.Text = selRow.Cells["customerIdRow"].Value.ToString();
                customerPhone.Text = selRow.Cells["customerPhoneRow"].Value.ToString();
                CarTextBox.Text = selRow.Cells["customerCarRow"].Value.ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

    }
}
