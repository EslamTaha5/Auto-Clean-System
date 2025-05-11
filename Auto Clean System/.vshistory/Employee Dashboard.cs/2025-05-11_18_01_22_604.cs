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
        public EmployeeDashboard(StaffClass staffUser) {
            InitializeComponent();

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
        private void pictureBox1_Click(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void pictureBox1_Click_1(object sender, EventArgs e) {

        }

        private void managerUsername_TextChanged(object sender, EventArgs e) {

        }

        private void label7_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label8_Click(object sender, EventArgs e) {

        }

        private void customerId_TextChanged(object sender, EventArgs e) {

        }

        private void btnCreate_Click(object sender, EventArgs e) {

        }

        private void btnUpdate_Click(object sender, EventArgs e) {

        }

        private void btnDelete_Click(object sender, EventArgs e) {

        }

        private void tabPage3_Click(object sender, EventArgs e) {
        }

        private void submit_button_Click(object sender, EventArgs e) {

        }

        private void Loginbutton_Click(object sender, EventArgs e) {

        }

        private void label5_Click_1(object sender, EventArgs e) {

        }

        private void EmployeeTap_Click(object sender, EventArgs e) {



        }
    }
}
