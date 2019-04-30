-- insert Movie
CREATE OR ALTER PROCEDURE Movie.InsertNewMovie
@Title NVARCHAR(512),
@IsAdult BIT,
@Runtime INT,
@ReleaseYear INT,
@StudioID INT,
@GenreID INT
AS
declare @NewMovieID INT 
BEGIN
	SET @NewMovieID = (SELECT MAX(MovieID) FROM Movie.Movies)+1;
        INSERT INTO Movie.Movies (MovieID, Title, IsAdult, Runtime, ReleaseYear, StudioID, GenreID)
		VALUES ((SELECT MAX(MovieID) FROM Movie.Movies)+1, @Title, @IsAdult, @Runtime, @ReleaseYear, @StudioID, @GenreID);
    COMMIT TRANSACTION
    RETURN @NewMovieID
END;

