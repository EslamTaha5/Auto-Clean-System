namespace Auto_Clean_System {
    partial class TryForm {
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
            this.autoCleanDatabaseDataSet = new Auto_Clean_System.AutoCleanDatabaseDataSet();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.customerTableAdapter = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.CustomerTableAdapter();
            this.tableAdapterManager = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.TableAdapterManager();
            this.merchantBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.merchantTableAdapter = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.MerchantTableAdapter();
            this.ordersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersTableAdapter = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.OrdersTableAdapter();
            this.ordersDetailsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ordersDetailsTableAdapter = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.OrdersDetailsTableAdapter();
            this.servicesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.servicesTableAdapter = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.ServicesTableAdapter();
            this.staffBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.staffTableAdapter = new Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.StaffTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.autoCleanDatabaseDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).BeginInit();
            this.SuspendLayout();
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
            this.tableAdapterManager.MerchantTableAdapter = this.merchantTableAdapter;
            this.tableAdapterManager.OrdersDetailsTableAdapter = this.ordersDetailsTableAdapter;
            this.tableAdapterManager.OrdersTableAdapter = this.ordersTableAdapter;
            this.tableAdapterManager.ServicesTableAdapter = this.servicesTableAdapter;
            this.tableAdapterManager.StaffTableAdapter = this.staffTableAdapter;
            this.tableAdapterManager.UpdateOrder = Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // merchantBindingSource
            // 
            this.merchantBindingSource.DataMember = "Merchant";
            this.merchantBindingSource.DataSource = this.autoCleanDatabaseDataSet;
            // 
            // merchantTableAdapter
            // 
            this.merchantTableAdapter.ClearBeforeFill = true;
            // 
            // ordersBindingSource
            // 
            this.ordersBindingSource.DataMember = "Orders";
            this.ordersBindingSource.DataSource = this.autoCleanDatabaseDataSet;
            // 
            // ordersTableAdapter
            // 
            this.ordersTableAdapter.ClearBeforeFill = true;
            // 
            // ordersDetailsBindingSource
            // 
            this.ordersDetailsBindingSource.DataMember = "OrdersDetails";
            this.ordersDetailsBindingSource.DataSource = this.autoCleanDatabaseDataSet;
            // 
            // ordersDetailsTableAdapter
            // 
            this.ordersDetailsTableAdapter.ClearBeforeFill = true;
            // 
            // servicesBindingSource
            // 
            this.servicesBindingSource.DataMember = "Services";
            this.servicesBindingSource.DataSource = this.autoCleanDatabaseDataSet;
            // 
            // servicesTableAdapter
            // 
            this.servicesTableAdapter.ClearBeforeFill = true;
            // 
            // staffBindingSource
            // 
            this.staffBindingSource.DataMember = "Staff";
            this.staffBindingSource.DataSource = this.autoCleanDatabaseDataSet;
            // 
            // staffTableAdapter
            // 
            this.staffTableAdapter.ClearBeforeFill = true;
            // 
            // TryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "TryForm";
            this.Text = "TryForm";
            this.Load += new System.EventHandler(this.TryForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.autoCleanDatabaseDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.merchantBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ordersDetailsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.servicesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.staffBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private AutoCleanDatabaseDataSet autoCleanDatabaseDataSet;
        private System.Windows.Forms.BindingSource customerBindingSource;
        private AutoCleanDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private AutoCleanDatabaseDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private AutoCleanDatabaseDataSetTableAdapters.MerchantTableAdapter merchantTableAdapter;
        private System.Windows.Forms.BindingSource merchantBindingSource;
        private AutoCleanDatabaseDataSetTableAdapters.OrdersTableAdapter ordersTableAdapter;
        private System.Windows.Forms.BindingSource ordersBindingSource;
        private AutoCleanDatabaseDataSetTableAdapters.OrdersDetailsTableAdapter ordersDetailsTableAdapter;
        private System.Windows.Forms.BindingSource ordersDetailsBindingSource;
        private AutoCleanDatabaseDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private System.Windows.Forms.BindingSource servicesBindingSource;
        private AutoCleanDatabaseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private System.Windows.Forms.BindingSource staffBindingSource;
    }
}