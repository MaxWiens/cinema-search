using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            string connectionString = "Data Source=mssql.cs.ksu.edu;Integrated Security=True";
            NonQuery nq = new NonQuery(connectionString:connectionString);
            nq.PopulateFunctions();
            SqlQueryExecutor s = new SqlQueryExecutor(connectionString: connectionString);
            s.SearchByTitle("Bee");
            Application.Run(new MovieListView());
        }
    }
}
