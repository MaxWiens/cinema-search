
CREATE OR ALTER PROCEDURE Movie.GetNextMovieIDForInsertion
AS
 SELECT max(MovieID) + 1 from Movie.Movies
GO

-- insert Movie
CREATE OR ALTER PROCEDURE Movie.InsertNewMovie
@Title NVARCHAR(512),
@IsAdult BIT,
@Runtime INT,
@ReleaseYear INT
AS
declare @NewMovieID INT 
exec @NewMovieID = Movie.GetNextMovieIDForInsertion
BEGIN
    BEGIN TRANSACTION
        INSERT Movie.Movies(MovieID, Title, IsAdult, Runtime, ReleaseYear)
        VALUES ( @NewMovieID, @Title, @IsAdult, @Runtime, @ReleaseYear)
    COMMIT TRANSACTION
    RETURN @NewMovieID
END

CREATE OR ALTER PROCEDURE Movie.InsertNewRating
@Rating FLOAT,
@NewMovieID INT
AS 
BEGIN
    BEGIN TRANSACTION
        INSERT Movie.Rating(MovieID, Rating)
        VALUES (@NewMovieID, @Rating)
    COMMIT TRANSACTION
END

CREATE OR ALTER PROCEDURE Movie.UpdateMovie
@MovieID INT,
@Title NVARCHAR(512),
@IsAdult BIT,
@Runtime INT,
@ReleaseYear INT
AS 
UPDATE [Movie].[Movies]
SET
    Title = @Title,
    IsAdult = @IsAdult,
    Runtime = @Runtime,
    ReleaseYear = @ReleaseYear
WHERE MovieID = @MovieID
RETURN @MovieID
GO
