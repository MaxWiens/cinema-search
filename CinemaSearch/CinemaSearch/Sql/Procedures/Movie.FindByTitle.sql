CREATE OR ALTER PROCEDURE Movie.FindByTitle
	@Title NVARCHAR(64)
AS

SELECT M.Title	
FROM Movie.Movies M
WHERE M.Title LIKE @Title