/*
Defines procedure to add a person, given their Name, and BirthYear
It makes sure to increment the PersonID
*/CREATE OR ALTER PROCEDURE Movie.AddPerson
	@Name NVARCHAR(512),
	@BirthYear INT
AS
INSERT INTO Movie.Person (PersonID, [Name], BirthYear)
VALUES ((SELECT MAX(PersonID) FROM Movie.Person)+1, @Name, @BirthYear);