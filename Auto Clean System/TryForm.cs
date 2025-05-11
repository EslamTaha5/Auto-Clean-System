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
    public partial class TryForm : Form {
        public TryForm() {
            InitializeComponent();
        }

        private void customerBindingNavigatorSaveItem_Click(object sender, EventArgs e) {
            this.Validate();
            this.customerBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.autoCleanDatabaseDataSet);

        }

        private void TryForm_Load(object sender, EventArgs e) {
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Staff' table. You can move, or remove it, as needed.
            this.staffTableAdapter.Fill(this.autoCleanDatabaseDataSet.Staff);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Services' table. You can move, or remove it, as needed.
            this.servicesTableAdapter.Fill(this.autoCleanDatabaseDataSet.Services);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.OrdersDetails' table. You can move, or remove it, as needed.
            this.ordersDetailsTableAdapter.Fill(this.autoCleanDatabaseDataSet.OrdersDetails);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Orders' table. You can move, or remove it, as needed.
            this.ordersTableAdapter.Fill(this.autoCleanDatabaseDataSet.Orders);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Merchant' table. You can move, or remove it, as needed.
            this.merchantTableAdapter.Fill(this.autoCleanDatabaseDataSet.Merchant);
            // TODO: This line of code loads data into the 'autoCleanDatabaseDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.autoCleanDatabaseDataSet.Customer);

        }
    }
}
