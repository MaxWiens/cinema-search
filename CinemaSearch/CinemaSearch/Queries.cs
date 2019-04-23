using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace CinemaSearch
{
    class SqlQueryExecutor
    {
        string connectionString;
        public SqlQueryExecutor(string connectionString)
        {
            this.connectionString = connectionString;
        }
        public IList SearchByTitle(string title)



        {
            title = '%' + title + '%';

            ArrayList results = new ArrayList();

            using (SqlConnection connection = new SqlConnection(this.connectionString))
            {
                SqlCommand command = new SqlCommand(queryString, connection);
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

        public NonQuery(string procString, string connectionString)
        {
            // this is used to create a stored procedure
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                using (SqlCommand command = new SqlCommand(procString, connection))
                {
                    connection.Open();
                    command.CommandType = System.Data.CommandType.Text;
                    command.ExecuteNonQuery();
                    connection.Close();
                }
            }
        }
    }
}
