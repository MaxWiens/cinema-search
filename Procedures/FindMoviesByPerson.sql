CREATE OR ALTER PROCEDURE FindMoviesByPerson @name NVARCHAR(256)
AS
SELECT DISTINCT Title FROM Movie.Movies M
JOIN Movie.Person P on P.Name = @name
JOIN Movie.Actor A on A.MovieID = M.MovieID
JOIN Movie.Director D on D.MovieID = M.MovieID
WHERE P.PersonID = D.PersonID OR P.PersonID = A.PersonID;