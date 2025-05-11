using Auto_Clean_System.AutoCleanDatabaseDataSetTableAdapters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clean_System
{

    internal static class Program
    {

        public static AutoCleanDatabaseDataSet AppDataSet { get; private set; }

        // TableAdapters
        public static CustomerTableAdapter CustomerAdapter { get; private set; }
        public static MerchantTableAdapter MerchantAdapter { get; private set; }
        public static OrdersTableAdapter OrdersAdapter { get; private set; }
        public static OrdersDetailsTableAdapter OrdersDetailsAdapter { get; private set; }
        public static ServicesTableAdapter ServicesAdapter { get; private set; }
        public static StaffTableAdapter StaffAdapter { get; private set; }

        // Binding Sources
        public static BindingSource CustomerBindingSource { get; private set; }
        public static BindingSource MerchantBindingSource { get; private set; }
        public static BindingSource OrdersBindingSource { get; private set; }
        public static BindingSource OrdersDetailsBindingSource { get; private set; }
        public static BindingSource ServicesBindingSource { get; private set; }
        public static BindingSource StaffBindingSource { get; private set; }

        // TableAdapterManager
        public static TableAdapterManager AdapterManager { get; private set; }
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            InitializeApplication();

            Application.Run(new RoleSelection());
        }

        private static void InitializeApplication() {
            // Initialize dataset
            AppDataSet = new AutoCleanDatabaseDataSet();

            // Initialize TableAdapters
            CustomerAdapter = new CustomerTableAdapter();
            MerchantAdapter = new MerchantTableAdapter();
            OrdersAdapter = new OrdersTableAdapter();
            OrdersDetailsAdapter = new OrdersDetailsTableAdapter();
            ServicesAdapter = new ServicesTableAdapter();
            StaffAdapter = new StaffTableAdapter();

            CustomerBindingSource = new BindingSource { DataSource = AppDataSet, DataMember = "Customer" };
            MerchantBindingSource = new BindingSource { DataSource = AppDataSet, DataMember = "Merchant" };
            OrdersBindingSource = new BindingSource { DataSource = AppDataSet, DataMember = "Orders" };
            OrdersDetailsBindingSource = new BindingSource { DataSource = AppDataSet, DataMember = "OrdersDetails" };
            ServicesBindingSource = new BindingSource { DataSource = AppDataSet, DataMember = "Services" };
            StaffBindingSource = new BindingSource { DataSource = AppDataSet, DataMember = "Staff" };

            // Configure TableAdapterManager
            AdapterManager = new TableAdapterManager {
                CustomerTableAdapter = CustomerAdapter,
                MerchantTableAdapter = MerchantAdapter,
                OrdersTableAdapter = OrdersAdapter,
                OrdersDetailsTableAdapter = OrdersDetailsAdapter,
                ServicesTableAdapter = ServicesAdapter,
                StaffTableAdapter = StaffAdapter,
                BackupDataSetBeforeUpdate = true,
                UpdateOrder = TableAdapterManager.UpdateOrderOption.InsertUpdateDelete
            };
        }


    }

}

