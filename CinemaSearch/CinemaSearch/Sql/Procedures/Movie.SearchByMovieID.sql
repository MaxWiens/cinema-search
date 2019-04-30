CREATE OR ALTER PROCEDURE Movie.SearchByMovieID
	@MovieID INT
AS
SELECT M.MovieID, M.Title, M.IsAdult, M.RunTime, M.ReleaseYear, R.Rating, S.StudioName, G.GenreName
FROM Movie.Movies M
	LEFT JOIN Movie.Rating R ON R.MovieID = M.MovieID
	LEFT JOIN Movie.Genre G ON G.GenreID = M.GenreID
	LEFT JOIN Movie.Studio S ON S.StudioID = M.StudioID
WHERE M.MovieID = @MovieID