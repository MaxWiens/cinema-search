using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.IO;

/*
namespace CinemaSearch
{
    class SqlQueryExecutor
    {
        string connectionString;
        public SqlQueryExecutor(string connectionString)
        {
            this.connectionString = connectionString;
            //sourceFiles()
        }
        public IList SearchByTitle(string title)
        {
            title = '%' + title + '%';

            ArrayList results = new ArrayList();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand("SELECT MovieID, MovieTitle FROM Movie.SortByTitle('@MovieTitle')", connection);
                command.Parameters.AddWithValue("@MovieTitle", title);
                connection.Open();
                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    results.Add(r["movieTitle"]);
                }
                connection.Close();
            };
            return results;
        }


    }

    class NonQuery
    {
        private List<string> functionFiles = new List<string> { "SortByTitle.sql" };
        SqlConnection connection;

        public NonQuery(string connectionString)
        {

            // this is used to create a stored procedure
            connection =  new SqlConnection(connectionString);
            
                
            
        }
        public bool PopulateFunctions()
        {
            string baseDir = Path.Combine (Directory.GetParent (Directory.GetParent (System.IO.Directory.GetCurrentDirectory().ToString()).ToString()).ToString(), "SQLQueries");// Get base directory of where the sql query files are

            foreach (string filename in functionFiles)
            {
                string fullFilePath = Path.Combine(baseDir, filename);
                string contents = File.ReadAllText(fullFilePath);
                using (SqlCommand command = new SqlCommand(contents, connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
            return true; 
        }
    }
}
*/