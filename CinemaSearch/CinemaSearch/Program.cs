using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataAccess;
using System.Data.OleDb;

namespace CinemaSearch
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Integrated Security=True";
            //NonQuery nq = new NonQuery(connectionString:connectionString);
            nq.PopulateFunctions();
            SqlCommandExecutor executor = new SqlCommandExecutor(connectionString: connectionString);
            //executor.FindByTitle("Bee");
            Application.Run(new MovieListView());
        }
    }
}
