CREATE OR ALTER PROCEDURE Movie.UpdateMovie
@MovieID INT,
@Title NVARCHAR(512),
@IsAdult BIT,
@Runtime INT,
@ReleaseYear INT,
@StudioID INT,
@GenreID INT
AS
BEGIN TRAN
	UPDATE [Movie].[Movies]
	SET
		Title = @Title,
		IsAdult = @IsAdult,
		Runtime = @Runtime,
		ReleaseYear = @ReleaseYear,
		StudioID = @StudioID,
		GenreID = @GenreID
	WHERE MovieID = @MovieID
COMMIT TRAN
;
