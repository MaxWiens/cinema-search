using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;


// example call: LoadDatabase(@"C:\Users\nebab\Downloads\DatabaseInfo\DatabaseInfo", "Server=(localdb)\\v11.0;Integrated Security=true;");

        public void LoadDatabase(string databaseFileDirPath, string connectionString)
        {
            foreach (string file in System.IO.Directory.EnumerateFiles(databaseFileDirPath, "*.tsv"))
            {
                string[,] data = ParseFile(file);
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    switch (data[0,0])
                    {
                        case "Movies":
                            // Create new command string for inserting into Movie.Movies table.
                            string commandStringMovies =
                                "INSERT INTO Movie.Movies(MovieID, Title, IsAdult, Runtime, ReleaseYear) VALUES(@movieID, @title, @isAdult, @runtime, @releaseYear)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringMovies, connection))
                                {
                                    command.Parameters.AddWithValue("@movieID", data[row, 0]);
                                    command.Parameters.AddWithValue("@title", data[row, 1]);
                                    command.Parameters.AddWithValue("@isAdult", data[row, 2]);
                                    command.Parameters.AddWithValue("@runtime", data[row, 3]);
                                    command.Parameters.AddWithValue("@releaseYear", data[row, 4]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "Actor":
                            // Create new command string for inserting into Movie.Actor table.
                            string commandStringActor =
                                "INSERT INTO Movie.Actor(MovieID, PersonID, Character) VALUES(@movieID, @personID, @character)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringActor, connection))
                                {
                                    command.Parameters.AddWithValue("@movieID", data[row, 0]);
                                    command.Parameters.AddWithValue("@personID", data[row, 1]);
                                    command.Parameters.AddWithValue("@character", data[row, 2]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "Genre":
                            // Create new command string for inserting into Movie.Genre table.
                            string commandStringGenre =
                                "INSERT INTO Movie.Genre(GenreID, GenreName) VALUES(@genreID, @genreName)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringGenre, connection))
                                {
                                    command.Parameters.AddWithValue("@genreID", data[row, 0]);
                                    command.Parameters.AddWithValue("@genreName", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "Language":
                            // Create new command string for inserting into Movie.Language table.
                            string commandStringLang =
                                "INSERT INTO Movie.Language(LanguageID, LanguageName) VALUES(@langID, @langName)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringLang, connection))
                                {
                                    command.Parameters.AddWithValue("@langID", data[row, 0]);
                                    command.Parameters.AddWithValue("@langName", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "Director":
                            // Create new command string for inserting into Movie.Director table.
                            string commandStringDirector =
                                "INSERT INTO Movie.Director(MovieID, PersonID,) VALUES(@movieID, @personID)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringDirector, connection))
                                {
                                    command.Parameters.AddWithValue("@movieID", data[row, 0]);
                                    command.Parameters.AddWithValue("@personID", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "MovieGenre":
                            // Create new command string for inserting into Movie.MovieGenre table.
                            string commandStringMovieGenre =
                                "INSERT INTO Movie.MovieGenre(MovieID, GenreName) VALUES(@movieID, @genreName)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringMovieGenre, connection))
                                {
                                    command.Parameters.AddWithValue("@movieID", data[row, 0]);
                                    command.Parameters.AddWithValue("@genreName", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "MovieLanguage":
                            // Create new command string for inserting into Movie.MovieLangage table.
                            string commandStringMovieLanguage = 
                                "INSERT INTO Movie.MovieLanguage(MovieID, LanguageName) VALUES(@movieID, @langName)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringMovieLanguage, connection))
                                {
                                    command.Parameters.AddWithValue("@movieID", data[row, 0]);
                                    command.Parameters.AddWithValue("@langName", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "MovieRegion":
                            // Create new command string for inserting into Movie.MovieRegion table.
                            string commandStringMovieRegion =
                                "INSERT INTO Movie.MovieRegion(MovieID, PersonID, Character) VALUES(@movieID, @regionName)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringMovieRegion, connection))
                                {
                                    command.Parameters.AddWithValue("@movieID", data[row, 0]);
                                    command.Parameters.AddWithValue("@regionName", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "Person":
                            // Create new command string for inserting into Movie.Person table.
                            string commandStringPerson =
                                "INSERT INTO Movie.Actor(PersonID, PersonName, birthYear) VALUES(@personID, @personName, @birthYear)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringPerson, connection))
                                {
                                    command.Parameters.AddWithValue("@personID", data[row, 0]);
                                    command.Parameters.AddWithValue("@personName", data[row, 1]);
                                    command.Parameters.AddWithValue("@birthYear", data[row, 2]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "Rating":
                            // Create new command string for inserting into Movie.Rating table.
                            string commandStringRating =
                                "INSERT INTO Movie.Rating(MovieID, Rating) VALUES(@movieID, @rating)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringRating, connection))
                                {
                                    command.Parameters.AddWithValue("@movieID", data[row, 0]);
                                    command.Parameters.AddWithValue("@rating", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        case "Region":
                            // Create new command string for inserting into Movie.Actor table.
                            string commandStringRegion =
                                "INSERT INTO Movie.Region(RegionID, RegionName) VALUES(@regionID, @regionName)";

                            // Execute the insert command once per row, using the values from that row.
                            connection.Open();
                            for (int row = 1; row < data.GetLength(0); row++)
                            {
                                using (SqlCommand command = new SqlCommand(commandStringRegion, connection))
                                {
                                    command.Parameters.AddWithValue("@regionID", data[row, 0]);
                                    command.Parameters.AddWithValue("@regionName", data[row, 1]);

                                    command.ExecuteNonQuery();
                                }
                            }
                            break;
                        default:
                            break;
                    }
                }

            }
        }

        private static string[,] ParseFile(string path)
        {

            // Read and store rows from text file.
            string[] rows = System.IO.File.ReadAllLines(path);

            // Establish boundries of return array.
            int rowCount = rows.Length;
            int fieldCount = (rows[1].Split('\t')).Count();

            // Create return array.
            string[,] returnArr = new string[rowCount, fieldCount];

            // Iterate through rows from file and split at commas.
            for (int rowIndex = 0; rowIndex < rowCount; rowIndex++)
            {
                string[] fields = rows[rowIndex].Split('\t');

                // Insert the values from the fields in each row into return array.
                for (int fieldIndex = 0; fieldIndex < fieldCount; fieldIndex++)
                {
                    returnArr[rowIndex, fieldIndex] = fields[fieldIndex];
                }
            }
            return returnArr;
        }