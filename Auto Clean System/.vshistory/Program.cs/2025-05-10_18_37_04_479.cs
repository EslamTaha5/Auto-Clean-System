using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Auto_Clean_System
{

    internal static class Program
    {
        public static AutoCleanDatabaseDataSet appDataSet {  get; set; }
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
        private static void LoadData()
    {
        // Example: Load data into the "Users" table
        var usersTableAdapter = new UsersTableAdapter();
        usersTableAdapter.Fill(AppDataSet.Users);

        // Repeat for other tables (e.g., Roles, Orders, etc.)
    }
    }
}
