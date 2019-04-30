/*
Searches for a Person with name similar to @Name
*/CREATE OR ALTER PROCEDURE Movie.PersonFromName
	@Name NVARCHAR(512)
AS
SELECT P.PersonID, P.Name
FROM Movie.Person P
WHERE P.Name like @Name
;