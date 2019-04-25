using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;
using System.IO;
using System.Collections.Specialized;
using System.Collections;

namespace CinemaSearch
{
    class SqlInterface
    {
        private string _sqlDir;
        private string _connectionString;


        public SqlInterface(string connectionString)
        {
            _sqlDir = Path.GetFullPath(Directory.GetCurrentDirectory() + "..\\..\\..\\SQL\\");
            _connectionString = connectionString;
        }


        public void InitalizeDatabase()
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT 1 FROM sys.databases DB WHERE DB.name = N'CinemaSearch'", connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();
                    
                    if (result == null)
                    {
                        Server s = new Server(new ServerConnection(connection));
                        s.AttachDatabase("CinemaSearch", new StringCollection { _sqlDir + "Data\\CinemaSearch.mdf" });
                    }
                }

                connection.ChangeDatabase("CinemaSearch");
                
                /*
                string[] functionFiles = {
                    "Queries\\SortByTitle.sql"
                };

                foreach (string filename in functionFiles)
                {
                    string contents = File.ReadAllText(_sqlDir + filename);
                    using (SqlCommand command = new SqlCommand(contents, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
                */
            }
        }

        public ArrayList SearchByTitle(string title)
        {
            ArrayList results = new ArrayList();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.SortByTitle", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("MovieTitle", '%' + title + '%');
                
                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                    results.Add(r["movieTitle"]);

                connection.Close();
            }
            return results;
        }
    }
}
