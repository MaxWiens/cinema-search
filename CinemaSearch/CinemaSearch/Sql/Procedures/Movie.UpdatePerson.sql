CREATE OR ALTER PROCEDURE Movie.UpdatePerson
	@PersonID INT,
	@Name NVARCHAR(512),
	@BirthYear INT
AS
UPDATE Movie.Person
SET
	Name = @Name,
	BirthYear = @BirthYear
WHERE
	PersonID = @PersonID;