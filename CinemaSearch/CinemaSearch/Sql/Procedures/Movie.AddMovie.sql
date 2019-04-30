CREATE OR ALTER PROCEDURE Movie.AddMovie
	@Title NVARCHAR(512),
	@IsAsult BIT,
	@Runtime INT,
	@ReleaseYear INT,
	@StudioID INT,
	@GenreID INT
AS
INSERT INTO Movie.Movies (MovieID, Title, IsAdult, Runtime, ReleaseYear, StudioID, GenreID)
VALUES ((SELECT MAX(MovieID) FROM Movie.Movies)+1, @Title, @IsAsult, @Runtime, @ReleaseYear, @StudioID, @GenreID);