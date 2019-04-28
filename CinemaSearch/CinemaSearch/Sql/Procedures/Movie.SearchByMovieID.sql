CREATE OR ALTER PROCEDURE Movie.SearchByMovieID
	@MovieID INT
AS
SELECT M.MovieID, M.Title, M.IsAdult, M.RunTime, M.ReleaseYear, R.Rating, MG.GenreName
FROM Movie.Movies M
	LEFT JOIN Movie.Rating R on R.MovieID = M.MovieID
	LEFT JOIN Movie.MovieGenre MG on MG.MovieID = M.MovieID
WHERE M.MovieID = @MovieID