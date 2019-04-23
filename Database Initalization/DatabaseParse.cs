using System;
using System.Collections.Generic;
using System.Data.SqlClient;

// Imports CSV files into database. "dataFilesPath" is a path to directory containing the CSV files. "connectionString" is the SQL connection string of your local DB.
// Be aware that this function takes a considerable amount of time to run.
public void LoadDatabase(string dataFilesPath, string connnectionString)
{
	// Change these paths to match the file locations on your local machine.
	string moviesPath = @"C:\MovieSearch\Movie.Movies.tsv";
	string actorPath = @"C:\MovieSearch\Movie.Actor.tsv";
	string directorPath = @"C:\MovieSearch\Movie.Director.tsv";
	string genrePath = @"C:\MovieSearch\Movie.Genre.tsv";
	string movieGenrePath = @"C:\MovieSearch\Movie.MovieGenre.tsv";
	string languagePath = @"C:\MovieSearch\Movie.Language.tsv";
	string movieLanguagePath = @"C:\MovieSearch\Movie.MovieLanguage.tsv";
	string personPath = @"C:\MovieSearch\Movie.Person.tsv";
	string regionPath = @"C:\MovieSearch\Movie.Region.tsv";
	string movieRegionPath = @"C:\MovieSearch\Movie.MovieRegion.tsv";
	string ratingPath = @"C:\MovieSearch\Movie.Rating.tsv";

	string[] filePaths = { moviesPath, actorPath, directorPath, genrePath, movieGenrePath, languagePath, movieLanguagePath, personPath, regionPath, movieRegionPath, ratingPath };
	string[] tables = { "Movie.Movies", "Movie.Actor", "Movie.Director", "Movie.Genre", "Movie.MovieGenre", "Movie.Language", "Movie.MovieLanguage", "Movie.Person", "Movie.Region", "Movie.MovieRegion", "Movie.Rating" };

	using(SqlConnection connection = new SqlConnection(connnectionString))
	{
		connection.Open();
		for (int tableIndex = 0; tableIndex < tables.Length; tableIndex++)
		{
			// Skipping the Movie.Director table until the data file is fixed.
			if(tableIndex == 2)
			{
				tableIndex++;
			}
			string commandString = "BULK INSERT "+tables[tableIndex]+" FROM '" + filePaths[tableIndex] + "' WITH (FIELDTERMINATOR = '\t', ROWTERMINATOR = '0x0a');";
			using (SqlCommand command = new SqlCommand(commandString, connection))
			{
				command.CommandTimeout = 120;
				command.ExecuteNonQuery();
			}
		}
	}
}

// Creates or recreates the tables of the data base. "setupFilePath" is a path to DataBaseSetup.sql file. "connectionString" is the SQL connection string of your local DB.
public void SetupDatabase(string setupFilePath, string connectionString)
{

	string script = System.IO.File.ReadAllText(setupFilePath);

	SqlConnection connnection = new SqlConnection(connectionString);
	connnection.Open();

	SqlCommand command = new SqlCommand(script, connnection);
	command.ExecuteNonQuery();
}        
