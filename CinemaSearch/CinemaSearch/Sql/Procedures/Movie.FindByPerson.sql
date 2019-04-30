/*
Defines a procedure that will find any movie titles that have an actor or director
with name similar to @PersonName
*/CREATE OR ALTER PROCEDURE Movie.FindByPerson
	@PersonName NVARCHAR(64)
AS

SELECT M.Title	
FROM Movie.Movies M
	INNER JOIN Movie.Director D ON D.MovieID = M.MovieID
	INNER JOIN Movie.Actor A ON A.MovieID = M.MovieID
	INNER JOIN Movie.Person P ON D.PersonID = P.PersonID
	INNER JOIN Movie.Person P ON A.PersonID = P.PersonID
WHERE P.[Name] LIKE @PersonName