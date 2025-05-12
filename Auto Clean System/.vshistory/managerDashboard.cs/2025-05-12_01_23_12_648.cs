using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using static Auto_Clean_System.AutoCleanDatabaseDataSet;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters;

namespace Auto_Clean_System {
    public partial class managerDashboard : Form {
        StaffClass staffUser = null;
        List<string> servicesNames = new List<string>();
        List<int> servicesCost = new List<int>();
        public managerDashboard(StaffClass staffUser) {
            InitializeComponent();
            this.staffUser = staffUser;
            fillData();
            initPages();


        }

        private void tabControl_DrawItem(object sender, DrawItemEventArgs e) {
            TabPage tabPage = tabControl.TabPages[e.Index];
            Rectangle tabBounds = tabControl.GetTabRect(e.Index);

            bool isSelected = (e.Index == tabControl.SelectedIndex);

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
        void initPages() {
            txtEmployeeNameOrder.Text = staffUser.name;

        }
        void fillData() {
            managerUsername.Text = staffUser.name;
            managerId.Text = staffUser.staffID.ToString();
            managerPassword.Text = staffUser.password;

        }

        private void managerDashboard_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.OrdersDetails' table. You can move, or remove it, as needed.
            this.ordersDetailsTableAdapter.Fill(this.autoCleanDatabaseDataSet.OrdersDetails);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Merchant' table. You can move, or remove it, as needed.
            this.merchantTableAdapter.Fill(this.autoCleanDatabaseDataSet.Merchant);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            // this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);
            this.staffTableAdapter.showEmployees(this.autoCleanDatabaseDataSet.Staff);
            this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);
            this.merchantTableAdapter.Fill(this.autoCleanDatabaseDataSet.Merchant);
            loadServicesIntoComboBox();
            initReports();
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSe

        }


        

        /// Second Panel (Employee)

        private void showEmployeesToolStripButton_Click(object sender, EventArgs e) {
            try {
                this.staffTableAdapter.showEmployees(this.autoCleanDatabaseDataSet.Staff);
            } catch (System.Exception ex) {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
        private void showAllEmployeeBtn_Click(object sender, EventArgs e) {
            this.staffTableAdapter.showEmployees(this.autoCleanDatabaseDataSet.Staff);

        }
        StaffClass checkUser() {
            if (!long.TryParse(employeeId.Text, out long userID)) {
                MessageBox.Show("Invalid ID");
                return null;
            }
            if (!decimal.TryParse(employeeBonus.Text, out decimal userBonus)) {
                MessageBox.Show("Invalid Bonus");
                return null;
            }
            if (!decimal.TryParse(employeeSalary.Text, out decimal userSalary)) {
                MessageBox.Show("Invalid Salary");
                return null;
            }

            staffUser = new StaffClass();
            string name = employeeName.Text;
            string password = employeePassword.Text;
            if (password.Length == 0) {
                MessageBox.Show("Invalid Password");
                return null;
            }
            StaffClass user = new StaffClass(name, userID, userSalary, userBonus, password, 0);
            return user;
        }
        void insertIntoDataBase() {
            Program.StaffAdapter.insertEmployee(staffUser.staffID, staffUser.name, staffUser.password, staffUser.salary, staffUser.bonus, staffUser.isManager);
            Program.StaffBindingSource.EndEdit();
            Program.AdapterManager.UpdateAll(Program.AppDataSet);
            Program.SaveAllData();
            this.staffTableAdapter.showEmployees(this.autoCleanDatabaseDataSet.Staff);

        }
        private void btnCreate_Click(object sender, EventArgs e) {
            staffUser = checkUser();

            if (staffUser == null) {
                return;
            }

            insertIntoDataBase();


        }


        private void showAllBtn_Click(object sender, EventArgs e) {
            this.customerTableAdapter.Fill(autoCleanDatabaseDataSet.Customer);
        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string name = employeeName.Text;
            this.staffTableAdapter.FindByName(this.autoCleanDatabaseDataSet.Staff, name);
        }

       
        private void employeeDataGrid_CellContentClick_1(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }
            DataGridViewRow selRow = employeeDataGrid.Rows[e.RowIndex];

            try {

                employeeName.Text = selRow.Cells["staffNameCol"].Value.ToString();
                employeeId.Text = selRow.Cells["staffIdCol"].Value.ToString();
                employeeSalary.Text = selRow.Cells["staffSalaryCol"].Value.ToString();
                employeePassword.Text = selRow.Cells["staffPassCol"].Value.ToString();
                employeeBonus.Text = selRow.Cells["staffBonusCol"].Value.ToString();

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e) {
            StaffClass user = checkUser();
            if (user == null) return;
            DialogResult result = MessageBox.Show($"Update User With ID {user.staffID}", "Update User", MessageBoxButtons.YesNo);
            if (result.Equals(DialogResult.Yes)) {
                try {
                    this.staffTableAdapter.updateUser(user.name, user.password, user.salary, user.bonus, user.staffID);
                    this.staffBindingSource.EndEdit();
                    this.tableAdapterManager.UpdateAll(autoCleanDatabaseDataSet);
                    this.staffTableAdapter.showEmployees(autoCleanDatabaseDataSet.Staff);
                }catch(Exception ex) {
                    MessageBox.Show($"Error while updating customer {ex.Message}");
                }
            }
        }

        // Services Panel
        private void btnSearchService_Click(object sender, EventArgs e) {
            string name = serviceName.Text;
            this.servicesTableAdapter.FindServiceByName(this.autoCleanDatabaseDataSet.Services, name);

        }

        ServiceClass getService() {
            if (!int.TryParse(serviceId.Text, out int serID)) {
                return null;
            }
            if (!decimal.TryParse(serviceCost.Text, out decimal cost)) {

                return null;
            }
            string name = serviceName.Text;
            if (name.Length == 0) return null;
            ServiceClass ser = new ServiceClass(serID, name, cost);
            return ser;
        }

        void insertService(ServiceClass service) {
            try {
                this.servicesTableAdapter.insertService(service.serviceId, service.serviceName, service.serviceCost);
                Program.ServicesBindingSource.EndEdit();
                Program.AdapterManager.UpdateAll(Program.AppDataSet);
                Program.SaveAllData();
                this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);
                MessageBox.Show("Service inserted Successfully");

            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }
        private void btnCreateService_Click(object sender, EventArgs e) {
            ServiceClass service = getService();
            if (service == null) {
                MessageBox.Show("Invalid Service");
            }
            insertService(service);
        }

        private void servicesDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e) {
            if (e.RowIndex == -1) {
                return;
            }
            DataGridViewRow selRow = servicesDataGridView.Rows[e.RowIndex];

            try {

                serviceId.Text = selRow.Cells["ServiceIDCol"].Value.ToString();
                serviceName.Text = selRow.Cells["ServiceNameCol"].Value.ToString();
                serviceCost.Text = selRow.Cells["StandardCostCol"].Value.ToString();
                Console.WriteLine(selRow.Cells["ServiceIDCol"]);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }

        }
        string getServiceName(int ID) {
            object result = this.servicesTableAdapter.FindServiceNameById(ID);
            Console.WriteLine(result == null);
            return Convert.ToString(result);
        }
        private void btnDeleteService_Click(object sender, EventArgs e) {

            ServiceClass service = getService();

            if (service == null) {
                MessageBox.Show("Invalid Service");
                return;
            }

            Console.WriteLine($"Service ID : {service.serviceId}");
            service.serviceName = getServiceName(service.serviceId);

            DialogResult res = MessageBox.Show($"Delete Service {service.serviceName}!", "Delete Service", MessageBoxButtons.YesNo);
            if (res.Equals(DialogResult.Yes)) {
                this.servicesTableAdapter.deleteService(service.serviceId);
                Program.StaffBindingSource.EndEdit();
                Program.AdapterManager.UpdateAll(Program.AppDataSet);
                Program.SaveAllData();
                this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);

            }
        }

        private void btnUpdateService_Click(object sender, EventArgs e) {
            ServiceClass service = getService();

            if (service == null) {
                MessageBox.Show("Invalid Service");
                return;
            }

            Console.WriteLine($"Service ID : {service.serviceId}");
            DialogResult res = MessageBox.Show($"Update Service with ID{service.serviceId}!", "Update Service", MessageBoxButtons.YesNo);

            if (res.Equals(DialogResult.Yes)) {
                this.servicesTableAdapter.updateService(service.serviceName, service.serviceCost, service.serviceId);
                Program.StaffBindingSource.EndEdit();
                Program.AdapterManager.UpdateAll(Program.AppDataSet);
                Program.SaveAllData();
                this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);

            }

        }
        // Customer Panel
        private void btnSearchCustomer_Click(object sender, EventArgs e) {
            string customerIdString = customerId.Text;
            string customerNameString = customerName.Text;
            string customerCarString = CarTextBox.Text;
            if (!int.TryParse(customerIdString, out int CustomerIdNum)) {
                customerIdString = "0";
            }
            CustomerIdNum = int.Parse(customerIdString);
            Console.WriteLine($"NAME : {customerNameString}, ID {CustomerIdNum}, Car {customerCarString}");

            this.customerTableAdapter.FindCustomerByNameAndCar(autoCleanDatabaseDataSet.Customer, customerNameString);
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e) {

        }

        CustomerClass getCustomer() {
            CustomerClass customer = new CustomerClass();

            customer.customerName = customerName.Text;
            customer.customerCar = CarTextBox.Text;
            if (customer.customerName.Length == 0 || customer.customerCar.Length == 0) {
                return null;
            }

            if (!int.TryParse(customerId.Text, out int tempID)) {
                return null;
            }
            customer.customerID = tempID;
            if (!long.TryParse(customerPhone.Text, out long tempPhone)) {
                return null;
            }
            customer.phoneNumber = tempPhone;
            return customer;
        }
        void updateCustomer(CustomerClass customer) {
            try {


            } catch (Exception e) {
                MessageBox.Show(e.Message);
            }
        }

        private void btnUpdateCustomer_Click(object sender, EventArgs e) {
            CustomerClass customer = getCustomer();
            if (customer == null) {
                MessageBox.Show("Invalid Customer Data");
                return;
            }
            DialogResult res = MessageBox.Show($"Update Customer with ID{customer.customerID}!", "Update Customer", MessageBoxButtons.YesNo);

            if (res.Equals(DialogResult.Yes)) {
                this.customerTableAdapter.updateCustomer(customer.customerName, customer.phoneNumber, customer.customerID);
                Program.StaffBindingSource.EndEdit();
                Program.AdapterManager.UpdateAll(Program.AppDataSet);
                Program.SaveAllData();
                this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);

            }

            updateCustomer(customer);

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
        // Order Page
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

                cmbServices.DataSource = autoCleanDatabaseDataSet.Services;
                cmbServices.DisplayMember = "ServiceName";
                cmbServices.ValueMember = "ServiceName";
                cmbServices.SelectedIndex = -1;


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
            if (tmpDiscount < 0 || tmpDiscount > 100) return false;
            return true;
        }

        OrderPage getOrderData() {
            if (!checkData()) {

                return null;
            }
            OrderPage orderPage = new OrderPage();

            orderPage.ServiceName = combServiceNameOrder.Text;

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
                this.fKOrderStaffBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(autoCleanDatabaseDataSet);

            }catch(Exception ex) {
                MessageBox.Show($"Error In Order Insert {ex.Message}");
            }
        }

        void insertDetails(OrderPage order) {
            try {

                this.ordersDetailsTableAdapter.insertOrderDetail(order.orderID,order.ServiceName, order.cost);
                this.ordersDetailsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(autoCleanDatabaseDataSet);

            } catch (Exception ex) {
                MessageBox.Show($"Error In Order Detail Insert {ex.Message}");
            }
        }
        void initReports() {

            try {

                // Bind the ComboBox
                
                cmbServices.SelectedIndex = -1;
                updateRevenue(-1, "");

            } catch (Exception ex) {
                MessageBox.Show($"Error loading services: {ex.Message}");
            }

        }
        
        private void addOrderBtn_Click(object sender, EventArgs e) {
            OrderPage order = getOrderData();

            if (order == null) {
                MessageBox.Show("Invalid Order Data!");
                return;
            }
            
            insertOrder(order);
            initReports();
            MessageBox.Show("Order Completed!");

        }

        private void combServiceNameOrder_SelectedIndexChanged(object sender, EventArgs e) {
            // Check if an item is actually selected
            if (combServiceNameOrder.SelectedItem == null || combServiceNameOrder.SelectedIndex < 0) {
                txtCostOrder.Text = "0.00";
                totalPriceLabel.Text = "0.00";
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
            totalPriceLabel.Text = total.ToString();
        }

        private void txtDiscountOrder_TextChanged(object sender, EventArgs e) {
            CalculateTotal();
        }

        private void tabProfile_Click(object sender, EventArgs e) {

        }

        Merchant getMerchant() {
            if (merchantName.Text.Length == 0) return null;
            if (!int.TryParse(merchantCost.Text, out int cost)) return null;
            if (!long.TryParse(MerchantId.Text, out long id)) ;
            if (merchantDeal.Text.Length == 0) return null;
            Merchant mer = new Merchant(merchantName.Text, merchantDeal.Text, cost, id, merchantDate.Value.ToUniversalTime());
            return mer;
        }
        private void btnCreateMerchant_Click(object sender, EventArgs e) {
            Merchant mer = getMerchant();
            if (mer == null) {
                MessageBox.Show("Invalid Merchant data!");
                return;
            }

            this.merchantTableAdapter.insertMerchant(mer.id, mer.name, mer.dealName, mer.cost, mer.time.Date);
            this.merchantBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(autoCleanDatabaseDataSet);
            this.merchantTableAdapter.Fill(autoCleanDatabaseDataSet.Merchant);

        }

        private void btnSearchMerchant_Click(object sender, EventArgs e) {
            string name = merchantName.Text;
            this.merchantTableAdapter.FindByName(autoCleanDatabaseDataSet.Merchant,name);

        }

        private void showAllMerchantBtn_Click(object sender, EventArgs e) {
            this.merchantTableAdapter.Fill(autoCleanDatabaseDataSet.Merchant);
        }

        private void btnDeleteMerchant_Click(object sender, EventArgs e) {
            if(!long.TryParse(MerchantId.Text, out long id)) {
                MessageBox.Show("Invalid Merchant ID!");
                return;
            }
            DialogResult result = MessageBox.Show("Delete Selected Merchant !", "Delete Merchant!", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes) {
                this.merchantTableAdapter.deleteMerchant(id);
                this.merchantBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(autoCleanDatabaseDataSet);
                this.merchantTableAdapter.Fill(autoCleanDatabaseDataSet.Merchant);
            }
        }

        private void tabCustomerService_Click(object sender, EventArgs e) {

        }

        private void cmbServices_SelectedIndexChanged(object sender, EventArgs e) {
            if (cmbServices.SelectedIndex == -1) {
                updateRevenue(-1, "");
            } else {
                updateRevenue(1, cmbServices.Text.ToString());
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
            object result2 = this.ordersTableAdapter.lastOrderID();
            order.orderID = Convert.ToInt32(result2);

            insertDetails(order);

        }

        void updateRevenue(int idx, string value) {
            long total = 0;
            DateTime dateFrom = reportFrom.Value;
            DateTime dateTo = reportTo.Value;
            if (idx == -1) {
                object result = this.ordersDetailsTableAdapter.getTotalRevenue(dateFrom.Date, dateTo.Date);
                if (result != null || result != DBNull.Value) total = Convert.ToInt64(result);
            } else {
                object result = this.ordersDetailsTableAdapter.getTotalRevenueService(dateFrom, dateTo, value);
                if(result != null ||result != DBNull.Value) total = Convert.ToInt64(result);
            }
            txtRevenue.Text = total.ToString();
            updateChart();

        }

        void updateChart() {
            DateTime dateFrom = reportFrom.Value;
            DateTime dateTo = reportTo.Value;

            object Result = this.ordersDetailsTableAdapter.serviceGroupsDetails(autoCleanDatabaseDataSet.OrdersDetails,dateFrom, dateTo);
            Console.WriteLine($"RESULT {Result}");
            if (Result == null || Result != DBNull.Value) return;
            var result = this.ordersDetailsTableAdapter.GetDataBy3(dateFrom, dateTo);
            
            // Print column headers
            Console.WriteLine("Service Name\tTotal");
            Console.WriteLine("--------------------------");

            // Print rows
            foreach (DataRow row in result.Rows) {
                string serviceName = row["ServiceName"].ToString();
                decimal total = Convert.ToDecimal(row["Total"]);
                Console.WriteLine($"{serviceName.PadRight(15)}\t{total:C}");
            }

        }

        private void reportFrom_ValueChanged(object sender, EventArgs e) {
            initReports();
        }

        private void reportTo_ValueChanged(object sender, EventArgs e) {
            initReports();
        }

        private void chart1_Click(object sender, EventArgs e) {

        }

        private void showAllReportsBtn_Click(object sender, EventArgs e) {
            updateRevenue(-1, "");
        }


        // Merchant Panel


    }
}
