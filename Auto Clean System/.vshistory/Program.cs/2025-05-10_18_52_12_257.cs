using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clean_System
{

    internal static class Program
    {
        public static AutoCleanDatabaseDataSet appDataSet = new AutoCleanDatabaseDataSet();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new RoleSelection());
        }
        private static AutoCleanDatabaseDataSetTableAdapters.CustomerTableAdapter customerTableAdapter;
        private static AutoCleanDatabaseDataSetTableAdapters.StaffTableAdapter staffTableAdapter;
        private static AutoCleanDatabaseDataSetTableAdapters.MerchantTableAdapter merchantTableAdapter;
        private static AutoCleanDatabaseDataSetTableAdapters.OrdersTableAdapter orderTableAdapter;
        private static AutoCleanDatabaseDataSetTableAdapters.ServicesTableAdapter servicesTableAdapter;
        private static AutoCleanDatabaseDataSetTableAdapters.OrdersDetailsTableAdapter ordersDetailsTableAdapter;


    }
}
