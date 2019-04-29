CREATE OR ALTER PROCEDURE FindMoviesByDirector @name NVARCHAR(256)
AS
SELECT DISTINCT Title FROM Movie.Movies M
JOIN Movie.Person P on P.Name = @name
JOIN Movie.Director D on D.PersonID = P.PersonID
WHERE M.MovieID = D.PersonID;