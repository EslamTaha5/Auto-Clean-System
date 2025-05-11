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
using System.Xml.Linq;

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
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            // this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);
            this.staffTableAdapter.showEmployees(this.autoCleanDatabaseDataSet.Staff);
            this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);
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
            Program.StaffBindingSource.EndEdit();
            Program.AdapterManager.UpdateAll(Program.AppDataSet);
            Program.SaveAllData();
            this.staffTableAdapter.showEmployees(this.autoCleanDatabaseDataSet.Staff);

        }
        private void btnCreate_Click(object sender, EventArgs e) {
            staffUser = checkUser();
            
            if (staffUser == null){
                return;
            }

            insertIntoDataBase();


        }

        private void btnSearch_Click(object sender, EventArgs e) {
            string name = employeeName.Text;
            this.staffTableAdapter.FindByName(this.autoCleanDatabaseDataSet.Staff, name);
        }

        private void employeeDataGrid_CellContentClick(object sender, DataGridViewCellEventArgs e) {

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
            Console.WriteLine("HERE");
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
            }catch(Exception ex) {
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
                this.servicesTableAdapter.updateService(service.serviceName,service.serviceCost, service.serviceId);
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
            string customerCarString = carTextBox.Text;
            if (!int.TryParse(customerIdString, out int CustomerIdNum)) {
                    customerIdString = "0";
            } 
            CustomerIdNum = int.Parse(customerIdString);
            Console.WriteLine($"NAME : {customerNameString}, ID {CustomerIdNum}, Car {customerCarString}");

            this.customerTableAdapter.FindCustomerByNameAndCar(autoCleanDatabaseDataSet.Customer, customerNameString, customerCarString, CustomerIdNum);
        }

        private void btnCreateCustomer_Click(object sender, EventArgs e) {

        }

        CustomerClass getCustomer() {
            CustomerClass customer = new CustomerClass();

            customer.customerName = customerName.Text;
            customer.customerCar = carTextBox.Text;
            if(customer.customerName.Length == 0 || customer.customerCar.Length == 0) {
                return null;
            }
            
            if(!int.TryParse(customerId.Text, out int tempID)) {
                return null ;
            }
            customer.customerID = tempID;
            if(!long.TryParse(customerPhone.Text, out long tempPhone)) {
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
            if(customer == null) {
                MessageBox.Show("Invalid Customer Data");
                return;
            }
            DialogResult res = MessageBox.Show($"Update Customer with ID{customer.customerID}!", "Update Customer", MessageBoxButtons.YesNo);

            if (res.Equals(DialogResult.Yes)) {
                this.customerTableAdapter.updateCustomer(customer.customerName, customer.phoneNumber, customer.customerCar, customer.customerID);
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
                customerId.Text = selRow.Cells["customerIdRow"].Value.ToString();
                customerId.Text = selRow.Cells["customerNameRow"].Value.ToString();
                customerPhone.Text = selRow.Cells["customerPhoneRow"].Value.ToString();
            } catch (Exception ex) {
                MessageBox.Show(ex.Message);
            }
        }

        bool checkData() {
            if (txtCarOrder.Text.Length == 0 ||
                txtCostOrder.Text.Length == 0 ||
                txtCustomerNameOrder.Text.Length == 0 ||
                txtEmployeeNameOrder.Text.Length == 0 ||
                txtPhoneOrder.Text.Length == 0||
                combServiceNameOrder.Text.Length == 0||
                combServiceNameOrder.SelectedItem == null)
                return false;
            if (!long.TryParse(txtPhoneOrder.Text, out long tmpPhone)) return false;
            return true;
        }

        OrderPage getOrderData() {
            if (!checkData()) {

                return null;
            }
            OrderPage orderPage = new OrderPage();
            Console.WriteLine(combServiceNameOrder.SelectedValue.ToString());
            return orderPage;
            orderPage.ServiceName = combServiceNameOrder.SelectedValue.ToString() ;
        }
        private void addOrderBtn_Click(object sender, EventArgs e) {
            OrderPage order = getOrderData();
            if(order == null) {
                MessageBox.Show("Invalid Order Data!";
            }
        }
        // Merchant Panel
    }
}
