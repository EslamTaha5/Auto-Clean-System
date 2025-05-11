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
    public partial class EmployeeLogin : Form {
        public EmployeeLogin() {
            InitializeComponent();
        }

        private void EmployeeLogin_Load(object sender, EventArgs e) {

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
