﻿
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
            this.components = new System.ComponentModel.Container();
            this.btnLogout = new System.Windows.Forms.Button();
            this.Employee_tab = new System.Windows.Forms.TabControl();
            this.EmployeeTap = new System.Windows.Forms.TabPage();
            this.Empdash_EmployeeName = new System.Windows.Forms.Panel();
            this.employeeNameTxt = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel15 = new System.Windows.Forms.Panel();
            this.employeeIdTxt = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.panel16 = new System.Windows.Forms.Panel();
            this.EmployeeBounsTxt = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.panel17 = new System.Windows.Forms.Panel();
            this.employeePaswordTxt = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.panel18 = new System.Windows.Forms.Panel();
            this.employeeSalaryTxt = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.picManager = new System.Windows.Forms.PictureBox();
            this.CustomerTap = new System.Windows.Forms.TabPage();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnCreate = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.customer_panel = new System.Windows.Forms.Panel();
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
            this.CustomerServiceTap = new System.Windows.Forms.TabPage();
            this.panel7 = new System.Windows.Forms.Panel();
            this.addOrderBtn = new System.Windows.Forms.Button();
            this.totalCostDiscount = new System.Windows.Forms.Label();
            this.totalCostlabel = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.combServiceNameOrder = new System.Windows.Forms.ComboBox();
            this.txtPhoneOrder = new System.Windows.Forms.TextBox();
            this.txtCostOrder = new System.Windows.Forms.TextBox();
            this.label26 = new System.Windows.Forms.Label();
            this.txtCustomerNameOrder = new System.Windows.Forms.TextBox();
            this.txtCarOrder = new System.Windows.Forms.TextBox();
            this.txtEmployeeNameOrder = new System.Windows.Forms.TextBox();
            this.txtDiscountOrder = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.autoCleanDatabaseDataSet = new Auto_Clean_System.AutoCleanDatabaseDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.TableAdapterManager();
            this.customerDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Employee_tab.SuspendLayout();
            this.EmployeeTap.SuspendLayout();
            this.Empdash_EmployeeName.SuspendLayout();
            this.panel8.SuspendLayout();
            this.panel15.SuspendLayout();
            this.panel16.SuspendLayout();
            this.panel17.SuspendLayout();
            this.panel18.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).BeginInit();
            this.CustomerTap.SuspendLayout();
            this.customer_panel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.CustomerServiceTap.SuspendLayout();
            this.panel7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCleanDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).BeginInit();
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
            // 
            // Empdash_EmployeeName
            // 
            this.Empdash_EmployeeName.Controls.Add(this.employeeNameTxt);
            this.Empdash_EmployeeName.Controls.Add(this.label10);
            this.Empdash_EmployeeName.Location = new System.Drawing.Point(437, 95);
            this.Empdash_EmployeeName.Name = "Empdash_EmployeeName";
            this.Empdash_EmployeeName.Size = new System.Drawing.Size(300, 54);
            this.Empdash_EmployeeName.TabIndex = 14;
            // 
            // employeeNameTxt
            // 
            this.employeeNameTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameTxt.Location = new System.Drawing.Point(96, 12);
            this.employeeNameTxt.Name = "employeeNameTxt";
            this.employeeNameTxt.ReadOnly = true;
            this.employeeNameTxt.Size = new System.Drawing.Size(194, 22);
            this.employeeNameTxt.TabIndex = 8;
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
            // panel15
            // 
            this.panel15.Controls.Add(this.employeeIdTxt);
            this.panel15.Controls.Add(this.label11);
            this.panel15.Location = new System.Drawing.Point(3, 59);
            this.panel15.Name = "panel15";
            this.panel15.Size = new System.Drawing.Size(300, 50);
            this.panel15.TabIndex = 14;
            // 
            // employeeIdTxt
            // 
            this.employeeIdTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeIdTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIdTxt.Location = new System.Drawing.Point(96, 11);
            this.employeeIdTxt.Name = "employeeIdTxt";
            this.employeeIdTxt.ReadOnly = true;
            this.employeeIdTxt.Size = new System.Drawing.Size(194, 22);
            this.employeeIdTxt.TabIndex = 8;
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
            this.panel16.Controls.Add(this.EmployeeBounsTxt);
            this.panel16.Controls.Add(this.label12);
            this.panel16.Location = new System.Drawing.Point(3, 227);
            this.panel16.Name = "panel16";
            this.panel16.Size = new System.Drawing.Size(300, 50);
            this.panel16.TabIndex = 14;
            // 
            // EmployeeBounsTxt
            // 
            this.EmployeeBounsTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeeBounsTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeBounsTxt.Location = new System.Drawing.Point(96, 12);
            this.EmployeeBounsTxt.Name = "EmployeeBounsTxt";
            this.EmployeeBounsTxt.ReadOnly = true;
            this.EmployeeBounsTxt.Size = new System.Drawing.Size(194, 22);
            this.EmployeeBounsTxt.TabIndex = 8;
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
            this.panel17.Controls.Add(this.employeePaswordTxt);
            this.panel17.Controls.Add(this.label13);
            this.panel17.Location = new System.Drawing.Point(3, 171);
            this.panel17.Name = "panel17";
            this.panel17.Size = new System.Drawing.Size(300, 50);
            this.panel17.TabIndex = 14;
            // 
            // employeePaswordTxt
            // 
            this.employeePaswordTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeePaswordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeePaswordTxt.Location = new System.Drawing.Point(96, 12);
            this.employeePaswordTxt.Name = "employeePaswordTxt";
            this.employeePaswordTxt.ReadOnly = true;
            this.employeePaswordTxt.Size = new System.Drawing.Size(194, 22);
            this.employeePaswordTxt.TabIndex = 8;
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
            this.panel18.Controls.Add(this.employeeSalaryTxt);
            this.panel18.Controls.Add(this.label14);
            this.panel18.Location = new System.Drawing.Point(3, 115);
            this.panel18.Name = "panel18";
            this.panel18.Size = new System.Drawing.Size(300, 50);
            this.panel18.TabIndex = 13;
            // 
            // employeeSalaryTxt
            // 
            this.employeeSalaryTxt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.employeeSalaryTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeSalaryTxt.Location = new System.Drawing.Point(96, 12);
            this.employeeSalaryTxt.Name = "employeeSalaryTxt";
            this.employeeSalaryTxt.ReadOnly = true;
            this.employeeSalaryTxt.Size = new System.Drawing.Size(194, 22);
            this.employeeSalaryTxt.TabIndex = 8;
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
            // CustomerTap
            // 
            this.CustomerTap.AutoScroll = true;
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
            // customer_panel
            // 
            this.customer_panel.Controls.Add(this.customerDataGridView);
            this.customer_panel.Location = new System.Drawing.Point(383, 52);
            this.customer_panel.Name = "customer_panel";
            this.customer_panel.Size = new System.Drawing.Size(491, 279);
            this.customer_panel.TabIndex = 45;
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
            // CustomerServiceTap
            // 
            this.CustomerServiceTap.BackColor = System.Drawing.Color.White;
            this.CustomerServiceTap.Controls.Add(this.panel7);
            this.CustomerServiceTap.Font = new System.Drawing.Font("Tahoma", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CustomerServiceTap.Location = new System.Drawing.Point(4, 52);
            this.CustomerServiceTap.Name = "CustomerServiceTap";
            this.CustomerServiceTap.Padding = new System.Windows.Forms.Padding(3);
            this.CustomerServiceTap.Size = new System.Drawing.Size(826, 441);
            this.CustomerServiceTap.TabIndex = 2;
            this.CustomerServiceTap.Text = "Customer Service";
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.addOrderBtn);
            this.panel7.Controls.Add(this.totalCostDiscount);
            this.panel7.Controls.Add(this.totalCostlabel);
            this.panel7.Controls.Add(this.label29);
            this.panel7.Controls.Add(this.label24);
            this.panel7.Controls.Add(this.combServiceNameOrder);
            this.panel7.Controls.Add(this.txtPhoneOrder);
            this.panel7.Controls.Add(this.txtCostOrder);
            this.panel7.Controls.Add(this.label26);
            this.panel7.Controls.Add(this.txtCustomerNameOrder);
            this.panel7.Controls.Add(this.txtCarOrder);
            this.panel7.Controls.Add(this.txtEmployeeNameOrder);
            this.panel7.Controls.Add(this.txtDiscountOrder);
            this.panel7.Controls.Add(this.label8);
            this.panel7.Controls.Add(this.label7);
            this.panel7.Controls.Add(this.label6);
            this.panel7.Controls.Add(this.label15);
            this.panel7.Controls.Add(this.label5);
            this.panel7.Location = new System.Drawing.Point(3, 6);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(817, 369);
            this.panel7.TabIndex = 1;
            // 
            // addOrderBtn
            // 
            this.addOrderBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(146)))), ((int)(((byte)(218)))));
            this.addOrderBtn.Font = new System.Drawing.Font("AwanZaman", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addOrderBtn.ForeColor = System.Drawing.SystemColors.Control;
            this.addOrderBtn.Location = new System.Drawing.Point(335, 296);
            this.addOrderBtn.MaximumSize = new System.Drawing.Size(120, 40);
            this.addOrderBtn.MinimumSize = new System.Drawing.Size(120, 40);
            this.addOrderBtn.Name = "addOrderBtn";
            this.addOrderBtn.Size = new System.Drawing.Size(120, 40);
            this.addOrderBtn.TabIndex = 10;
            this.addOrderBtn.Text = "Add Order";
            this.addOrderBtn.UseVisualStyleBackColor = false;
            this.addOrderBtn.Click += new System.EventHandler(this.addOrderBtn_Click_1);
            // 
            // totalCostDiscount
            // 
            this.totalCostDiscount.AutoSize = true;
            this.totalCostDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostDiscount.Location = new System.Drawing.Point(603, 214);
            this.totalCostDiscount.Name = "totalCostDiscount";
            this.totalCostDiscount.Size = new System.Drawing.Size(0, 20);
            this.totalCostDiscount.TabIndex = 20;
            // 
            // totalCostlabel
            // 
            this.totalCostlabel.AutoSize = true;
            this.totalCostlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalCostlabel.Location = new System.Drawing.Point(459, 217);
            this.totalCostlabel.Name = "totalCostlabel";
            this.totalCostlabel.Size = new System.Drawing.Size(96, 20);
            this.totalCostlabel.TabIndex = 19;
            this.totalCostlabel.Text = "Total Cost:";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("AwanZaman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.Location = new System.Drawing.Point(34, 212);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(66, 16);
            this.label29.TabIndex = 13;
            this.label29.Text = "Discount:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("AwanZaman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.Location = new System.Drawing.Point(31, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(69, 16);
            this.label24.TabIndex = 14;
            this.label24.Text = "Car Name:";
            // 
            // combServiceNameOrder
            // 
            this.combServiceNameOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.combServiceNameOrder.FormattingEnabled = true;
            this.combServiceNameOrder.Location = new System.Drawing.Point(178, 92);
            this.combServiceNameOrder.Name = "combServiceNameOrder";
            this.combServiceNameOrder.Size = new System.Drawing.Size(183, 32);
            this.combServiceNameOrder.TabIndex = 18;
            // 
            // txtPhoneOrder
            // 
            this.txtPhoneOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtPhoneOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneOrder.Location = new System.Drawing.Point(177, 148);
            this.txtPhoneOrder.Name = "txtPhoneOrder";
            this.txtPhoneOrder.Size = new System.Drawing.Size(184, 29);
            this.txtPhoneOrder.TabIndex = 16;
            // 
            // txtCostOrder
            // 
            this.txtCostOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCostOrder.Location = new System.Drawing.Point(607, 92);
            this.txtCostOrder.Name = "txtCostOrder";
            this.txtCostOrder.ReadOnly = true;
            this.txtCostOrder.Size = new System.Drawing.Size(183, 29);
            this.txtCostOrder.TabIndex = 16;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("AwanZaman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.Location = new System.Drawing.Point(460, 152);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(100, 16);
            this.label26.TabIndex = 15;
            this.label26.Text = "Phone Number:";
            // 
            // txtCustomerNameOrder
            // 
            this.txtCustomerNameOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCustomerNameOrder.Location = new System.Drawing.Point(607, 43);
            this.txtCustomerNameOrder.Name = "txtCustomerNameOrder";
            this.txtCustomerNameOrder.Size = new System.Drawing.Size(183, 29);
            this.txtCustomerNameOrder.TabIndex = 14;
            // 
            // txtCarOrder
            // 
            this.txtCarOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtCarOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCarOrder.Location = new System.Drawing.Point(607, 148);
            this.txtCarOrder.Name = "txtCarOrder";
            this.txtCarOrder.Size = new System.Drawing.Size(183, 29);
            this.txtCarOrder.TabIndex = 17;
            // 
            // txtEmployeeNameOrder
            // 
            this.txtEmployeeNameOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmployeeNameOrder.Location = new System.Drawing.Point(179, 40);
            this.txtEmployeeNameOrder.Name = "txtEmployeeNameOrder";
            this.txtEmployeeNameOrder.ReadOnly = true;
            this.txtEmployeeNameOrder.Size = new System.Drawing.Size(183, 29);
            this.txtEmployeeNameOrder.TabIndex = 13;
            // 
            // txtDiscountOrder
            // 
            this.txtDiscountOrder.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDiscountOrder.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscountOrder.Location = new System.Drawing.Point(177, 208);
            this.txtDiscountOrder.Name = "txtDiscountOrder";
            this.txtDiscountOrder.Size = new System.Drawing.Size(184, 29);
            this.txtDiscountOrder.TabIndex = 18;
            this.txtDiscountOrder.Text = "0.0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(459, 92);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 20);
            this.label8.TabIndex = 11;
            this.label8.Text = "Cost:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(30, 92);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 20);
            this.label7.TabIndex = 10;
            this.label7.Text = "Service Name:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(459, 43);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(142, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Customer Name:";
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
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(30, 43);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 23);
            this.label5.TabIndex = 0;
            // 
            // autoCleanDatabaseDataSet
            // 
            this.autoCleanDatabaseDataSet.DataSetName = "AutoCleanDatabaseDataSet";
            this.autoCleanDatabaseDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataMember = "Customer";
            this.customerBindingSource.DataSource = this.autoCleanDatabaseDataSet;
            // 
            // customerTableAdapter
            // 
            this.customerTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CustomerTableAdapter = this.customerTableAdapter;
            this.tableAdapterManager.MerchantTableAdapter = null;
            this.tableAdapterManager.OrdersDetailsTableAdapter = null;
            this.tableAdapterManager.OrdersTableAdapter = null;
            this.tableAdapterManager.ServicesTableAdapter = null;
            this.tableAdapterManager.StaffTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // customerDataGridView
            // 
            this.customerDataGridView.AutoGenerateColumns = false;
            this.customerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.customerDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.customerDataGridView.DataSource = this.customerBindingSource;
            this.customerDataGridView.Location = new System.Drawing.Point(0, 0);
            this.customerDataGridView.Name = "customerDataGridView";
            this.customerDataGridView.Size = new System.Drawing.Size(440, 279);
            this.customerDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "CustomerID";
            this.dataGridViewTextBoxColumn1.HeaderText = "CustomerID";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn3.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Car";
            this.dataGridViewTextBoxColumn4.HeaderText = "Car";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // EmployeeDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(8)))), ((int)(((byte)(41)))), ((int)(((byte)(74)))));
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Employee_tab);
            this.Controls.Add(this.btnLogout);
            this.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "EmployeeDashboard";
            this.Text = "Employee Dashboard";
            this.Load += new System.EventHandler(this.EmployeeDashboard_Load);
            this.Employee_tab.ResumeLayout(false);
            this.EmployeeTap.ResumeLayout(false);
            this.Empdash_EmployeeName.ResumeLayout(false);
            this.Empdash_EmployeeName.PerformLayout();
            this.panel8.ResumeLayout(false);
            this.panel15.ResumeLayout(false);
            this.panel15.PerformLayout();
            this.panel16.ResumeLayout(false);
            this.panel16.PerformLayout();
            this.panel17.ResumeLayout(false);
            this.panel17.PerformLayout();
            this.panel18.ResumeLayout(false);
            this.panel18.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picManager)).EndInit();
            this.CustomerTap.ResumeLayout(false);
            this.customer_panel.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.CustomerServiceTap.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel7.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.autoCleanDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button btnLogout;
        private System.Windows.Forms.TabControl Employee_tab;
        private System.Windows.Forms.TabPage EmployeeTap;
        private System.Windows.Forms.TabPage CustomerTap;
        private System.Windows.Forms.Panel Empdash_EmployeeName;
        private System.Windows.Forms.TextBox employeeNameTxt;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel15;
        private System.Windows.Forms.TextBox employeeIdTxt;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Panel panel16;
        private System.Windows.Forms.TextBox EmployeeBounsTxt;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Panel panel17;
        private System.Windows.Forms.TextBox employeePaswordTxt;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Panel panel18;
        private System.Windows.Forms.TextBox employeeSalaryTxt;
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
        private System.Windows.Forms.ComboBox combServiceNameOrder;
        private System.Windows.Forms.TextBox txtCostOrder;
        private System.Windows.Forms.TextBox txtCustomerNameOrder;
        private System.Windows.Forms.TextBox txtEmployeeNameOrder;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalCostlabel;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox txtPhoneOrder;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.TextBox txtCarOrder;
        private System.Windows.Forms.TextBox txtDiscountOrder;
        private System.Windows.Forms.Label totalCostDiscount;
        private System.Windows.Forms.Button addOrderBtn;
        private AutoCleanDatabaseDataSet autoCleanDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AutoCleanDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private AutoCleanDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView customerDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}