/*IF OBJECT_ID(N'Movie.SortByTitle') IS NOT NULL
   DROP FUNCTION Movie.SortByTitle;
GO*/

CREATE FUNCTION Movie.SortByTitle(@MovieTitle NVARCHAR)
RETURNS TABLE 
AS 
RETURN(
	SELECT M.MovieID, M.Title as MovieTitle
	FROM Movie.Movies M
	WHERE M.Title LIKE @MovieTitle
	);
--GO
