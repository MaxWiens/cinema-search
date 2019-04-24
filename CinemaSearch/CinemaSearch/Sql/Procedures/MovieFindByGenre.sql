CREATE OR ALTER PROCEDURE Movie.FindByGenre
	@Genre NVARCHAR(32)
AS

SELECT M.Title	
FROM Movie.Movies M
	INNER JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
	LEFT JOIN Movie.Genre G ON MG.GenreID = G.GenreID
WHERE G.[Name] LIKE @Genre