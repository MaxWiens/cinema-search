CREATE OR ALTER PROCEDURE FindMoviesByActor @name NVARCHAR(256)
AS
SELECT DISTINCT Title FROM Movie.Movies M
JOIN Movie.Person P on P.Name = @name
JOIN Movie.Actor A on A.PersonID = P.PersonID
WHERE M.MovieID = A.PersonID;