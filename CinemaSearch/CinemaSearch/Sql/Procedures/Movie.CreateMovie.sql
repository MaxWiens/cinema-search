CREATE OR ALTER PROCEDURE Movie.CreateMovie
   @MovieID INT,
   @Title NVARCHAR(64),
   @IsAdult TINYINT,
   @Runtime INT,
   @ReleaseYear YEAR
AS

INSERT Person.Person(MovieID, Title, IsAdult, Runtime, ReleaseYear)
VALUES(@MovieID, @Title, @IsAdult, @Runtime, @ReleaseYear);

GO