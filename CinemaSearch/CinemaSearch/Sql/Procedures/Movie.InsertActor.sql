CREATE OR ALTER PROCEDURE Movie.InsertActor
@MovieID INT,
@PersonID INT,
@CharacterName NVARCHAR(128)
AS
BEGIN TRAN
	IF EXISTS (SELECT * FROM Movie.Actor A WHERE A.MovieID = @MovieID AND A.PersonID = @PersonID)
		UPDATE Movie.Actor SET CharacterName = @CharacterName 
	ELSE
		INSERT Movie.Actor(MovieID, PersonID, CharacterName)
        VALUES (@MovieID, @PersonID, @CharacterName)
COMMIT TRAN
;