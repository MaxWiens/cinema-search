CREATE OR ALTER PROCEDURE FindMoviesByGenre @genreName NVARCHAR(32)
AS
SELECT DISTINCT Title FROM Movie.Movies M
JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
JOIN Movie.Genre G ON G.GenreName = MG.GenreName
WHERE MG.GenreName = @genreName;