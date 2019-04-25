CREATE OR ALTER PROCEDURE Movie.SortByTitle
	@MovieTitle NVARCHAR(128)
AS
SELECT M.MovieID, M.Title AS MovieTitle
FROM Movie.Movies M
WHERE M.Title LIKE @MovieTitle;
GO
