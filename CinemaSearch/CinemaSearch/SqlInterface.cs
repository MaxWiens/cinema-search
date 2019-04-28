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
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace CinemaSearch
{
    public class SqlInterface
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
                
                
                string[] functionFiles = {
                    @"Procedures\Movie.Search.sql",
                    @"Procedures\Movie.SearchByMovieID.sql",
                    @"Procedures\Movie.AssociatedPeople.sql",
                    @"Procedures\Movie.GetDirector.sql"
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
                
            }
        }

        

        public List<AssociatedPerson> SearchAssociatedPeople(int movieID)
        {
            List<AssociatedPerson> results = new List<AssociatedPerson>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.AssocitedPerson", connection);

                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    object[] values = new object[4];
                    r.GetValues(values); // movieID, name, character, isDirector, 
                    int personID = (int)values[0];
                    string name = (string)values[1];
                    string character = (string)values[2];
                    bool isDirector = (bool)values[3];

                    results.Add(new AssociatedPerson(personID, character, name, isDirector));
                }
                connection.Close();
            }
            return results;
        }



        public List<AssociatedMovie> SearchAssociatedMovies(int actorID)
        {
            List<AssociatedMovie> results = new List<AssociatedMovie>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.AssocitedMoves", connection);

                SqlDataReader r = command.ExecuteReader();
                while (r.Read()) {
                    object[] values = new object[4];
                    r.GetValues(values); // movieID, MovieTitle, 
                    int movieID = (int)values[0];
                    string title = (string)values[1];
                    string character = (string)values[2];
                    bool isDirector = (bool)values[3];

                    results.Add(new AssociatedMovie(title, movieID, character, isDirector));
                }
                connection.Close();
            }
            return results;
        }




        public List<Movie> MovieSearch(string title, string genre, string person)
        {
            List<Movie> results = new List<Movie>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.Search", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("MovieTitle", '%' + title + '%');
                command.Parameters.AddWithValue("MovieGenre", '%' + genre + '%');
                command.Parameters.AddWithValue("PersonName", '%' + person + '%');

                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    object[] values = new object[2];
                    r.GetValues(values); //M.MovieID, M.Title, 

                    results.Add(new Movie((int)values[0], (string)values[1]));
                }

                connection.Close();
            }
            return results;
        }


        public Movie MovieSearchByMovieID(int movieID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {

                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.SearchByMovieID", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("MovieID", movieID);
                
                SqlDataReader r = command.ExecuteReader();
                if (r.Read()) {
                    object[] values = new object[7];
                    r.GetValues(values); //M.MovieID, M.Title, M.IsAdult, M.RunTime, M.ReleaseYear, R.Rating, MG.GenreName

                    bool? isAdult = values[2] == System.DBNull.Value ? null: new bool?((bool)values[2]);
                    int? runTime = values[3] == System.DBNull.Value || (int)values[3] < 0 ? null: new int?((int)values[3]);
                    int? releaseYear = values[4] == System.DBNull.Value || (int)values[3] < 0 ? null : new int?((int)values[4]);
                    float? rating = values[5] == System.DBNull.Value ? null : new float?((float)(double)values[5]);

                    AssociatedPerson director = MovieGetDirector((int)values[0]);
                    List<AssociatedPerson> actors = MovieAssociatedPeople((int)values[0]);
                    return new Movie((int)values[0], (string)values[1], isAdult, runTime, releaseYear, rating, director, actors, (string)values[6]);
                }
                connection.Close();
            }
            return null;
        }

        public void MovieUpdatePerson(int personID, string name, int? birthDate)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.UpdatePerson", connection);

                command.Parameters.AddWithValue("PersonID", personID);
                command.Parameters.AddWithValue("Name", name);
                command.Parameters.AddWithValue("BirthDate", birthDate);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
        }

        public void MovieAddPerson(string name, int? birthYear)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.AddPerson", connection);

                command.Parameters.AddWithValue("Name", name);
                if(birthYear == null)
                    command.Parameters.AddWithValue("BirthDate", null);
                else
                    command.Parameters.AddWithValue("BirthDate", birthYear.Value);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
        }

        public List<AssociatedPerson> MovieAssociatedPeople(int movieID)
        {
            List<AssociatedPerson> results = new List<AssociatedPerson>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.AssociatedPeople", connection);

                command.Parameters.AddWithValue("movieID", movieID);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    object[] values = new object[3];
                    r.GetValues(values); //id,name,charactername

                    string characters = (Regex.Replace(Regex.Replace((string)values[2], "\",\"", "\", \""), "\\[|\\]", String.Empty));
                    results.Add(new AssociatedPerson((int)values[0], (string)values[1], characters, false));
                }
            }
            return results;
        }

        public AssociatedPerson MovieGetDirector(int movieID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.GetDirector", connection);

                command.Parameters.AddWithValue("movieID", movieID);
                command.CommandType = System.Data.CommandType.StoredProcedure;
                SqlDataReader r = command.ExecuteReader();
                if (r.Read())
                {
                    object[] values = new object[2];
                    r.GetValues(values);
                    return new AssociatedPerson((int)values[0], (string)values[1], null, true);
                }
            }
            return null;
        }
    }
}
