﻿using System;
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

                    results.Add(new AssociatedMovie(movieID, title, character, isDirector));
                }
                connection.Close();
            }
            return results;
        }




        public List<Movie> MovieSearch(string name, string genre)
        {
            List<Movie> results = new List<Movie>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.Search", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("Name", '%' + name + '%');
                command.Parameters.AddWithValue("MovieGenre", '%' + genre + '%');

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

        public List<Person> PersonSearch(string name, string genre)
        {
            List<Person> results = new List<Person>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.PersonSearch", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("Name", '%' + name + '%');
                command.Parameters.AddWithValue("MovieGenre", '%' + genre + '%'); ;

                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    object[] values = new object[2];
                    r.GetValues(values); //PersonID, Name, 

                    results.Add(new Person((int)values[0], (string)values[1]));
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
                    object[] values = new object[8];
                    r.GetValues(values); //M.MovieID, M.Title, M.IsAdult, M.RunTime, M.ReleaseYear, R.Rating, MG.GenreName, S.StudioName

                    bool? isAdult = values[2] == System.DBNull.Value ? null : new bool?((bool)values[2]);
                    int? runTime = values[3] == System.DBNull.Value || (int)values[3] < 0 ? null : new int?((int)values[3]);
                    int? releaseYear = values[4] == System.DBNull.Value || (int)values[3] < 0 ? null : new int?((int)values[4]);
                    float? rating = values[5] == System.DBNull.Value ? null : new float?((float)(double)values[5]);
                    string studio = values[7] == System.DBNull.Value || (string)values[7] == string.Empty ? null : (string)values[7];

                    Person director = MovieGetDirector((int)values[0]);
                    List<AssociatedPerson> actors = MovieAssociatedPeople((int)values[0]);
                    return new Movie((int)values[0], (string)values[1], isAdult, runTime, releaseYear, rating, director, actors, (string)values[6], studio);
                }
                connection.Close();
            }
            return null;
        }

        public void MovieUpdatePerson(int personID, string name, int? birthYear)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.UpdatePerson", connection);

                command.Parameters.AddWithValue("PersonID", personID);
                command.Parameters.AddWithValue("Name", name);
                command.Parameters.AddWithValue("BirthYear", birthYear);

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
                if (birthYear == null)
                    command.Parameters.AddWithValue("BirthYear", System.DBNull.Value);
                else
                    command.Parameters.AddWithValue("BirthYear", birthYear.Value);

                command.CommandType = System.Data.CommandType.StoredProcedure;
                command.ExecuteNonQuery();
            }
        }
        
        public void MovieAddMovie(string title, bool? isAdult, int? runtime, int? year, int? studio, int? genre)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.AddMovie", connection);

                command.Parameters.AddWithValue("Title", title);
                
                if(isAdult == null) {
                    command.Parameters.AddWithValue("IsAdult", System.DBNull.Value);
                } else {
                    command.Parameters.AddWithValue("IsAdult", isAdult);
                }
                
                if(runtime == null) {
                    command.Parameters.AddWithValue("Runtime", System.DBNull.Value);
                } else {
                    command.Parameters.AddWithValue("Runtime", runtime);
                }
                
                if(year == null) {
                    command.Parameters.AddWithValue("ReleaseYear", System.DBNull.Value);
                } else {
                    command.Parameters.AddWithValue("ReleaseYear", year);
                }
                
                if(studio == null) {
                    command.Parameters.AddWithValue("StudioID", System.DBNull.Value);
                } else {
                    command.Parameters.AddWithValue("StudioID", studio);
                }
                
                if(genre == null) {
                    command.Parameters.AddWithValue("GenreID", System.DBNull.Value);
                } else {
                    command.Parameters.AddWithValue("GenreID", genre);
                }

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
                    string characters;
                    if (values[2] == System.DBNull.Value)
                        characters = null;
                    else
                        characters = (Regex.Replace(Regex.Replace((string)values[2], "\",\"", "\", \""), "\\[|\\]", String.Empty));
                    results.Add(new AssociatedPerson((int)values[0], (string)values[1], characters, false));
                }
            }
            return results;
        }



        public List<AssociatedMovie> MovieAssociatedMovies(int personID)
        {
            List<AssociatedMovie> results = new List<AssociatedMovie>();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.AssociatedMovies", connection);

                command.Parameters.AddWithValue("personID", personID);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                SqlDataReader r = command.ExecuteReader();
                while (r.Read())
                {
                    object[] values = new object[4];
                    r.GetValues(values); //MovieID, Title, Characters, IsDirector
                    string characters;
                    if (values[2] == System.DBNull.Value)
                        characters = null;
                    else
                        characters = (Regex.Replace(Regex.Replace((string)values[2], "\",\"", "\", \""), "\\[|\\]", String.Empty));
                    results.Add(new AssociatedMovie((int)values[0], (string)values[1], characters, (bool)values[3]));
                }
            }
            return results;
        }




        public Person MovieGetDirector(int movieID)
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
                    return new Person((int)values[0], (string)values[1]);
                }
            }
            return null;
        }

        public Person MoviePersonFromID(int personID)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.PersonFromID", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("PersonID", personID);

                SqlDataReader r = command.ExecuteReader();
                if (r.Read())
                {
                    object[] values = new object[3];
                    r.GetValues(values); //P.PersonID, P.[Name], P.BirthYear

                    int? birthYear = values[2] == System.DBNull.Value || (int)values[2] < 0 ? null : new int?((int)values[2]);

                    List<AssociatedMovie> associatedMovies = MovieAssociatedMovies(personID);
                    return new Person((int)values[0], (string)values[1], birthYear, associatedMovies);
                }
                connection.Close();
            }
            return null;
        }

        public Person MoviePersonFromName(string name)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Open();
                connection.ChangeDatabase("CinemaSearch");

                SqlCommand command = new SqlCommand("Movie.PersonFromName", connection);
                command.CommandType = System.Data.CommandType.StoredProcedure;

                command.Parameters.AddWithValue("Name", $"%{name}%");

                SqlDataReader r = command.ExecuteReader();
                if (r.Read())
                {
                    object[] values = new object[2];
                    r.GetValues(values); //P.PersonID, P.Name

                    return new Person((int)values[0], (string)values[1]);
                }
                connection.Close();
            }
            return null;
        }
    }
}
