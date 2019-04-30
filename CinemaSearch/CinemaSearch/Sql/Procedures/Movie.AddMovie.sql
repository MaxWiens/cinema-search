/*Defines procedure that takes a Title, whether it is Adult, Runtime, ReleaseYear,
StudioID, GenreID and inserts new movie, making sure to increment MovieID
*/
CREATE OR ALTER PROCEDURE Movie.AddMovie
	@Title NVARCHAR(512),
	@IsAdult BIT,
	@Runtime INT,
	@ReleaseYear INT,
	@StudioID INT,
	@GenreID INT
AS
INSERT INTO Movie.Movies (MovieID, Title, IsAdult, Runtime, ReleaseYear, StudioID, GenreID)
VALUES ((SELECT MAX(MovieID) FROM Movie.Movies)+1, @Title, @IsAdult, @Runtime, @ReleaseYear, @StudioID, @GenreID);
