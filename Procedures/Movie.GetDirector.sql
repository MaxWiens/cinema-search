/*
INPUT: A movie ID.
OUTPUT: The person ID and name of the director associated with given film.
*/
CREATE OR ALTER PROCEDURE Movie.GetDirector @movieID INT
AS
SELECT
	D.PersonID,
	P.Name 
FROM 
	Movie.Movies M
	JOIN Movie.Director D on D.MovieID = @movieID
	JOIN Movie.Person P on P.PersonID = D.PersonID
	GROUP BY D.PersonID, P.PersonID, P.Name;