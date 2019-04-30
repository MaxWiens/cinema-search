using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    public static class DatabaseInit
    {
        /// <summary>
        /// Checks if the database is already initialized. If is isn't, creates the database.
        /// </summary>
        /// <param name="_connectionString"></param>
        /// <returns></returns>
        public static void InitalizeDatabase(string _connectionString)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                using (SqlCommand command = new SqlCommand("SELECT 1 FROM sys.databases DB WHERE DB.name = N'CinemaSearch'", connection))
                {
                    connection.Open();
                    object result = command.ExecuteScalar();

                    if (result == null)
                    {
                        CreateDatabase(_connectionString);
                        CreateTables(_connectionString);
                    }
                }

                connection.ChangeDatabase("CinemaSearch");


                string[] functionFiles = {
                    @"Procedures\Movie.Search.sql",
                    @"Procedures\Movie.SearchByMovieID.sql",
                    @"Procedures\Movie.AssociatedPeople.sql",
                    @"Procedures\Movie.AssociatedMovies.sql",
                    @"Procedures\Movie.GetDirector.sql",
                    @"Procedures\Movie.PersonFromID.sql",
                    @"Procedures\Movie.PersonSearch.sql",
                    @"Procedures\Movie.AddPerson.sql",
                    @"Procedures\Movie.UpdatePerson.sql",
                    @"Procedures\Movie.AssociatedData.sql",
                    @"Procedures\Movie.RemoveActor.sql",
                    @"Procedures\Movie.InsertActor.sql",
                    @"Procedures\Movie.InsertDirector.sql",
                    @"Procedures\Movie.UpdateMovie.sql",
                    @"Procedures\Movie.InsertNewRating.sql"
                };

                foreach (string filename in functionFiles)
                {
                    string _sqlDir = Path.GetFullPath(Directory.GetCurrentDirectory() + @"..\..\..\SQL\");
                    string contents = File.ReadAllText(_sqlDir + filename);
                    using (SqlCommand command = new SqlCommand(contents, connection))
                    {
                        command.CommandType = System.Data.CommandType.Text;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        public static void PopulateDatabase(string connnectionString, string dataDir)
        {
            CreateTables(connnectionString);
            string _dataDir = dataDir + @"\";
            string moviesPath = _dataDir + "Movie.Movies.tsv";
            string actorPath = _dataDir + "Movie.Actor.tsv";
            string directorPath = _dataDir + "Movie.Director.tsv";
            string genrePath = _dataDir + "Movie.Genre.tsv";
            string personPath = _dataDir + "Movie.Person.tsv";
            string ratingPath = _dataDir + "Movie.Rating.tsv";
            string studioPath = _dataDir + "Movie.Studio.tsv";

            string[] filePaths = { moviesPath,  actorPath,      directorPath,     genrePath,     personPath,     ratingPath,     studioPath };
            string[] tables = { "Movie.Movies", "Movie.Actor",  "Movie.Director", "Movie.Genre", "Movie.Person", "Movie.Rating", "Movie.Studio" };

            using (SqlConnection connection = new SqlConnection(connnectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");
                for (int tableIndex = 0; tableIndex < tables.Length; tableIndex++)
                {
                    string commandString = "BULK INSERT " + tables[tableIndex] + " FROM '" + filePaths[tableIndex] + "' WITH (FIELDTERMINATOR = '\t', ROWTERMINATOR = '0x0a');";
                    using (SqlCommand command = new SqlCommand(commandString, connection))
                    {
                        command.CommandTimeout = 120;
                        command.ExecuteNonQuery();
                    }
                }
            }
        }

        // Creates or recreates the tables of the data base. "setupFilePath" is a path to DataBaseSetup.sql file. "connectionString" is the SQL connection string of your local DB.
        private static void CreateDatabase(string connectionString)
        {
            string _setupDir = Path.GetFullPath(Directory.GetCurrentDirectory() + @"..\..\..\SQL\");
            string script = System.IO.File.ReadAllText(_setupDir + @"Database\CreateDatabase.sql");
            string schemaScript = System.IO.File.ReadAllText(_setupDir + @"Schema\CreateSchema.sql");

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            SqlCommand command = new SqlCommand(script, connection);
            command.ExecuteNonQuery();

            connection.ChangeDatabase("CinemaSearch");

            SqlCommand buildSchema = new SqlCommand(schemaScript, connection);
            buildSchema.ExecuteNonQuery();
        }

        public static void CreateTables(string connectionString)
        {
            string _setupDir = Path.GetFullPath(Directory.GetCurrentDirectory() + @"..\..\..\SQL\Tables\");

            string tableScript = System.IO.File.ReadAllText(_setupDir + "CreateTables.sql");

            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            connection.ChangeDatabase("CinemaSearch");

            SqlCommand buildTables = new SqlCommand(tableScript, connection);
            buildTables.ExecuteNonQuery();
        }
    }
}
