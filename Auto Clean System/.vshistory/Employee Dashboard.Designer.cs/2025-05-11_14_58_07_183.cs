
namespace Auto_Clean_System {
    partial class EmployeeDashboard {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EmployeeDashboard));
            this.btnLogout = new System.Windows.Forms.Button();
            this.Employee_tab = new System.Windows.Forms.TabControl();
            this.EmployeeTap = new System.Windows.Forms.TabPage();
            this.CustomerTap = new System.Windows.Forms.TabPage();
            this.panel8 = new System.Windows.Forms.Panel();
            this.Empdash_EmployeeName = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel15 = new System.Windows.Forms.Panel();
            this.Empdash_employeeId = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.Empdash_EmployeeBouns = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.Empdash_EmployeePasword = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.Empdash_employeeSalary = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.picManager = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.emp_customerName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Emp_customerId = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.Emp_customerDiscount = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Emp_customerCar = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.customer_panel = new System.Windows.Forms.Panel();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.CustomerServiceTap = new System.Windows.Forms.TabPage();
            this.Employee_tab.SuspendLayout();
            this.EmployeeTap.SuspendLayout();
            this.CustomerTap.SuspendLayout();
            this.panel8.SuspendLayout();
            this.Empdash_EmployeeName.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.CustomerServiceTap.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnLogout
            // 
            this.btnLogout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnLogout.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLogout.Location = new System.Drawing.Point(831, 609);
            this.btnLogout.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnLogout.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(120, 40);
            this.btnLogout.TabIndex = 11;
            this.btnLogout.Text = "Logout";
            this.btnLogout.UseVisualStyleBackColor = false;
            this.btnLogout.Click += new System.EventHandler(this.btnLogout_Click);
            // 
            // Employee_tab
            // 
            this.Employee_tab.Controls.Add(this.EmployeeTap);
            this.Employee_tab.Controls.Add(this.CustomerTap);
            this.Employee_tab.Controls.Add(this.CustomerServiceTap);
            this.Employee_tab.Location = new System.Drawing.Point(83, 62);
            this.Employee_tab.Name = "Employee_tab";
            this.Employee_tab.Padding = new System.Drawing.Point(30, 18);
            this.Employee_tab.SelectedIndex = 0;
            this.Employee_tab.Size = new System.Drawing.Size(834, 497);
            this.Employee_tab.TabIndex = 12;
            // 
            // EmployeeTap
            // 
            this.EmployeeTap.BackColor = System.Drawing.Color.White;
            this.EmployeeTap.Controls.Add(this.Empdash_EmployeeName);
            this.EmployeeTap.Controls.Add(this.panel8);
            this.EmployeeTap.Controls.Add(this.picManager);
            this.EmployeeTap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeTap.Location = new System.Drawing.Point(4, 52);
            this.EmployeeTap.Name = "EmployeeTap";
            this.EmployeeTap.Padding = new System.Windows.Forms.Padding(3);
            this.EmployeeTap.Size = new System.Drawing.Size(826, 441);
            this.EmployeeTap.TabIndex = 0;
            this.EmployeeTap.Text = "Information";
            this.EmployeeTap.Click += new System.EventHandler(this.EmployeeTap_Click);
            // 
            // CustomerTap
            // 
            this.CustomerTap.BackColor = System.Drawing.Color.White;
            this.CustomerTap.Controls.Add(this.btnDelete);
            this.CustomerTap.Controls.Add(this.btnUpdate);
            this.CustomerTap.Controls.Add(this.btnCreate);
            this.CustomerTap.Controls.Add(this.btnSearch);
            this.CustomerTap.Controls.Add(this.customer_panel);
            this.CustomerTap.Controls.Add(this.panel1);
            this.CustomerTap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerTap.Location = new System.Drawing.Point(4, 52);
            this.CustomerTap.Name = "CustomerTap";
            this.CustomerTap.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerTap.Size = new System.Drawing.Size(826, 441);
            this.CustomerTap.TabIndex = 1;
            this.CustomerTap.Text = "Customer";
            // 
            // panel8
            // 
            this.panel8.Controls.Add(this.panel15);
            this.panel8.Controls.Add(this.panel16);
            this.panel8.Controls.Add(this.panel17);
            this.panel8.Controls.Add(this.panel18);
            this.panel8.Location = new System.Drawing.Point(434, 95);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(310, 284);
            this.panel8.TabIndex = 23;
            // 
            // Empdash_EmployeeName
            // 
            this.Empdash_EmployeeName.Controls.Add(this.textBox1);
            this.Empdash_EmployeeName.Controls.Add(this.label10);
            this.Empdash_EmployeeName.Location = new System.Drawing.Point(437, 95);
            this.Empdash_EmployeeName.Name = "Empdash_EmployeeName";
            this.Empdash_EmployeeName.Size = new System.Drawing.Size(300, 54);
            this.Empdash_EmployeeName.TabIndex = 14;
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(96, 12);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(194, 22);
            this.textBox1.TabIndex = 8;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 12);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(60, 20);
            this.label10.TabIndex = 7;
            this.label10.Text = "Name:";
            // 
            // panel15
            // 
            this.panel15.Controls.Add(this.Empdash_employeeId);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Location = new System.Drawing.Point(3, 59);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(300, 50);
            this.panel15.TabIndex = 14;
            // 
            // Empdash_employeeId
            // 
            this.Empdash_employeeId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Empdash_employeeId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empdash_employeeId.Location = new System.Drawing.Point(96, 11);
            this.Empdash_employeeId.Name = "Empdash_employeeId";
            this.Empdash_employeeId.Size = new System.Drawing.Size(194, 22);
            this.Empdash_employeeId.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 14);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(33, 20);
            this.label11.TabIndex = 7;
            this.label11.Text = "ID:";
            // 
            // panel16
            // 
            this.panel16.Controls.Add(this.Empdash_EmployeeBouns);
            this.panel16.Controls.Add(this.label12);
            this.panel16.Location = new System.Drawing.Point(3, 227);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(300, 50);
            this.panel16.TabIndex = 14;
            // 
            // Empdash_EmployeeBouns
            // 
            this.Empdash_EmployeeBouns.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Empdash_EmployeeBouns.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empdash_EmployeeBouns.Location = new System.Drawing.Point(96, 12);
            this.Empdash_EmployeeBouns.Name = "Empdash_EmployeeBouns";
            this.Empdash_EmployeeBouns.Size = new System.Drawing.Size(194, 22);
            this.Empdash_EmployeeBouns.TabIndex = 8;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(9, 14);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 7;
            this.label12.Text = "Bonus:";
            // 
            // panel17
            // 
            this.panel17.Controls.Add(this.Empdash_EmployeePasword);
            this.panel17.Controls.Add(this.label13);
            this.panel17.Location = new System.Drawing.Point(3, 171);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(300, 50);
            this.panel17.TabIndex = 14;
            // 
            // Empdash_EmployeePasword
            // 
            this.Empdash_EmployeePasword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Empdash_EmployeePasword.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empdash_EmployeePasword.Location = new System.Drawing.Point(96, 12);
            this.Empdash_EmployeePasword.Name = "Empdash_EmployeePasword";
            this.Empdash_EmployeePasword.Size = new System.Drawing.Size(194, 22);
            this.Empdash_EmployeePasword.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(9, 13);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(91, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Password:";
            // 
            // panel18
            // 
            this.panel18.Controls.Add(this.Empdash_employeeSalary);
            this.panel18.Controls.Add(this.label14);
            this.panel18.Location = new System.Drawing.Point(3, 115);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(300, 50);
            this.panel18.TabIndex = 13;
            // 
            // Empdash_employeeSalary
            // 
            this.Empdash_employeeSalary.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Empdash_employeeSalary.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empdash_employeeSalary.Location = new System.Drawing.Point(96, 12);
            this.Empdash_employeeSalary.Name = "Empdash_employeeSalary";
            this.Empdash_employeeSalary.Size = new System.Drawing.Size(194, 22);
            this.Empdash_employeeSalary.TabIndex = 8;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(9, 12);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(64, 20);
            this.label14.TabIndex = 7;
            this.label14.Text = "Salary:";
            // 
            // picManager
            // 
            this.picManager.Image = ((System.Drawing.Image)(resources.GetObject("picManager.Image")));
            this.picManager.Location = new System.Drawing.Point(120, 124);
            this.picManager.Margin = new System.Windows.Forms.Padding(0);
            this.picManager.MaximumSize = new System.Drawing.Size(200, 200);
            this.picManager.MinimumSize = new System.Drawing.Size(200, 200);
            this.picManager.Name = "picManager";
            this.picManager.Size = new System.Drawing.Size(200, 200);
            this.picManager.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picManager.TabIndex = 22;
            this.picManager.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Location = new System.Drawing.Point(34, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(310, 282);
            this.panel1.TabIndex = 44;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.emp_customerName);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(300, 50);
            this.panel2.TabIndex = 14;
            // 
            // emp_customerName
            // 
            this.emp_customerName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.emp_customerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emp_customerName.Location = new System.Drawing.Point(91, 16);
            this.emp_customerName.Name = "emp_customerName";
            this.emp_customerName.Size = new System.Drawing.Size(202, 22);
            this.emp_customerName.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 20);
            this.label1.TabIndex = 7;
            this.label1.Text = "Name:";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Emp_customerId);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(3, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(300, 50);
            this.panel3.TabIndex = 14;
            // 
            // Emp_customerId
            // 
            this.Emp_customerId.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Emp_customerId.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_customerId.Location = new System.Drawing.Point(95, 14);
            this.Emp_customerId.Name = "Emp_customerId";
            this.Emp_customerId.Size = new System.Drawing.Size(202, 22);
            this.Emp_customerId.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 16);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "ID:";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.Emp_customerDiscount);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Location = new System.Drawing.Point(3, 225);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(300, 50);
            this.panel4.TabIndex = 14;
            // 
            // Emp_customerDiscount
            // 
            this.Emp_customerDiscount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Emp_customerDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_customerDiscount.Location = new System.Drawing.Point(95, 14);
            this.Emp_customerDiscount.Name = "Emp_customerDiscount";
            this.Emp_customerDiscount.Size = new System.Drawing.Size(202, 22);
            this.Emp_customerDiscount.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 20);
            this.label3.TabIndex = 7;
            this.label3.Text = "Discount:";
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.Emp_customerCar);
            this.panel5.Controls.Add(this.label4);
            this.panel5.Location = new System.Drawing.Point(3, 151);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(300, 50);
            this.panel5.TabIndex = 13;
            // 
            // Emp_customerCar
            // 
            this.Emp_customerCar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Emp_customerCar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Emp_customerCar.Location = new System.Drawing.Point(95, 12);
            this.Emp_customerCar.Name = "Emp_customerCar";
            this.Emp_customerCar.Size = new System.Drawing.Size(202, 22);
            this.Emp_customerCar.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(46, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(42, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Car:";
            // 
            // customer_panel
            // 
            this.customer_panel.Location = new System.Drawing.Point(383, 52);
            this.customer_panel.Name = "customer_panel";
            this.customer_panel.Size = new System.Drawing.Size(383, 280);
            this.customer_panel.TabIndex = 45;
            // 
            // btnCreate
            // 
            this.btnCreate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(146)))), ((int)(((byte)(218)))));
            this.btnCreate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCreate.Location = new System.Drawing.Point(259, 375);
            this.btnCreate.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnCreate.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(120, 40);
            this.btnCreate.TabIndex = 49;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = false;
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(146)))), ((int)(((byte)(218)))));
            this.btnSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearch.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSearch.Location = new System.Drawing.Point(95, 375);
            this.btnSearch.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnSearch.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(120, 40);
            this.btnSearch.TabIndex = 48;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = false;
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.ForeColor = System.Drawing.SystemColors.Control;
            this.btnDelete.Location = new System.Drawing.Point(587, 375);
            this.btnDelete.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnDelete.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(120, 40);
            this.btnDelete.TabIndex = 51;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = false;
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(146)))), ((int)(((byte)(218)))));
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.ForeColor = System.Drawing.SystemColors.Control;
            this.btnUpdate.Location = new System.Drawing.Point(423, 375);
            this.btnUpdate.MaximumSize = new System.Drawing.Size(120, 40);
            this.btnUpdate.MinimumSize = new System.Drawing.Size(120, 40);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(120, 40);
            this.btnUpdate.TabIndex = 50;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(420, 66);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(381, 263);
            this.panel6.TabIndex = 0;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.comboBox1);
            this.panel7.Controls.Add(this.dateTimePicker1);
            this.panel7.Controls.Add(this.textBox5);
            this.panel7.Controls.Add(this.textBox3);
            this.panel7.Controls.Add(this.textBox2);
            this.panel7.Controls.Add(this.label9);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(15, 66);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(381, 263);
            this.panel7.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 0;
            this.label5.Click += new System.EventHandler(this.label5_Click_1);
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(30, 43);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(143, 20);
            this.label15.TabIndex = 8;
            this.label15.Text = "Employee Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(31, 86);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Name:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 135);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Service Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(31, 180);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cost:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(31, 227);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 20);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date:";
            // 
            // textBox2
            // 
            this.textBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox2.Location = new System.Drawing.Point(179, 40);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(183, 22);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox3.Location = new System.Drawing.Point(179, 86);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(183, 22);
            this.textBox3.TabIndex = 14;
            // 
            // textBox5
            // 
            this.textBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox5.Location = new System.Drawing.Point(179, 180);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(183, 22);
            this.textBox5.TabIndex = 16;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePicker1.Location = new System.Drawing.Point(179, 225);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(183, 23);
            this.dateTimePicker1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(179, 135);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(183, 24);
            this.comboBox1.TabIndex = 18;
            // 
            // CustomerServiceTap
            // 
            this.CustomerServiceTap.BackColor = System.Drawing.Color.White;
            this.CustomerServiceTap.Controls.Add(this.panel7);
            this.CustomerServiceTap.Controls.Add(this.panel6);
            this.CustomerServiceTap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerServiceTap.Location = new System.Drawing.Point(4, 52);
            this.CustomerServiceTap.Name = "CustomerServiceTap";
            this.CustomerServiceTap.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerServiceTap.Size = new System.Drawing.Size(826, 441);
            this.CustomerServiceTap.TabIndex = 2;
            this.CustomerServiceTap.Text = "Customer Service";
            this.CustomerServiceTap.Click += new System.EventHandler(this.tabPage3_Click);
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Employee_tab);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "EmployeeDashboard";
            this.Text = "Employee Dashboard";
            this.Employee_tab.ResumeLayout(false);
            this.EmployeeTap.ResumeLayout(false);
            this.CustomerTap.ResumeLayout(false);
            this.panel8.ResumeLayout(false);
            this.Empdash_EmployeeName.ResumeLayout(false);
            this.Empdash_EmployeeName.PerformLayout();
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            this.CustomerServiceTap.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl Employee_tab;
        private System.Windows.Forms.TabPage EmployeeTap;
        private System.Windows.Forms.TabPage CustomerTap;
        private System.Windows.Forms.Panel Empdash_EmployeeName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox Empdash_employeeId;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox Empdash_EmployeeBouns;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox Empdash_EmployeePasword;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox Empdash_employeeSalary;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.PictureBox picManager;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Panel customer_panel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox emp_customerName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox Emp_customerId;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.TextBox Emp_customerDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox Emp_customerCar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage CustomerServiceTap;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel6;
    }
}