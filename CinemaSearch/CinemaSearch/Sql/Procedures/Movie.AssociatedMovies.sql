/*
Defines a procedure to get all the Movies associated with a Person, given their ID
*/CREATE OR ALTER PROCEDURE Movie.AssociatedMovies 
	@personID INT
AS
SELECT
	M.MovieID,
	M.Title,
	IIF(A.PersonID = @personID, A.CharacterName, NULL) AS Characters,
	IIF(D.PersonID = @personID, CAST(1 AS BIT), CAST(0 AS BIT)) AS IsDirector
FROM Movie.Movies M
	LEFT JOIN Movie.Actor A ON A.MovieID = M.MovieID
	LEFT JOIN Movie.Director D ON D.MovieID = M.MovieID
WHERE A.PersonID = @personID OR D.PersonID = @personID