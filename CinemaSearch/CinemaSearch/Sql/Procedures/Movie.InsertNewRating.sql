CREATE OR ALTER PROCEDURE Movie.InsertNewRating
@MovieID INT,
@Rating FLOAT
AS 
BEGIN
    BEGIN TRANSACTION
        INSERT Movie.Rating(MovieID, Rating)
        VALUES (@MovieID, @Rating)
    COMMIT TRANSACTION
END;