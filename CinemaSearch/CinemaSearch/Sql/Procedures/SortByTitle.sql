CREATE OR ALTER PROCEDURE Movie.SortByTitle
	@MovieTitle NVARCHAR(512)
AS
SELECT M.MovieID, M.Title AS MovieTitle
FROM Movie.Movies M
WHERE M.Title LIKE @MovieTitle;
