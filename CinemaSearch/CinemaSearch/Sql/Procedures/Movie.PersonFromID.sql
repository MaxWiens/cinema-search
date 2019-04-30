/*
Gets information about a person from their ID
*/CREATE OR ALTER PROCEDURE Movie.PersonFromID
	@PersonID INT
AS
SELECT P.PersonID, P.[Name], P.BirthYear
FROM Movie.Person P
WHERE P.PersonID = @PersonID