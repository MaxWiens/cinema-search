CREATE OR ALTER PROCEDURE Movie.InsertDirector
@MovieID INT,
@PersonID int
as
BEGIN TRAN
	IF EXISTS (SELECT * FROM Movie.Director D WHERE D.MovieID = @MovieID)
		UPDATE Movie.Director SET PersonID = @PersonID 
	ELSE
		INSERT Movie.Director(MovieID, PersonID)
        VALUES (@MovieID, @PersonID)
COMMIT TRAN
;