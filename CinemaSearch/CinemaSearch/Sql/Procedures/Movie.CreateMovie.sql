/*
Defines procedure to create a movie, given the MovieID, Title, whether it is adult
Runtime, and ReleaseYear
*/CREATE OR ALTER PROCEDURE Movie.CreateMovie
   @MovieID INT,
   @Title NVARCHAR(64),
   @IsAdult TINYINT,
   @Runtime INT,
   @ReleaseYear YEAR
AS
BEGIN TRAN
INSERT Person.Person(MovieID, Title, IsAdult, Runtime, ReleaseYear)
VALUES(@MovieID, @Title, @IsAdult, @Runtime, @ReleaseYear)
COMMIT TRAN;