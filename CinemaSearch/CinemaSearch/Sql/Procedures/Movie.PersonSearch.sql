CREATE OR ALTER PROCEDURE Movie.PersonSearch
	@Name NVARCHAR(512),
	@MovieGenre NVARCHAR(512)
AS
SELECT AP.PersonID, AP.Name
	FROM Movie.Movies M 
		LEFT JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
		INNER JOIN Movie.Actor A ON A.MovieID = M.MovieID
		INNER JOIN Movie.Person AP ON AP.PersonID = A.PersonID
	WHERE
		(
			AP.[Name] LIKE @Name OR 
			A.CharacterName LIKE @Name OR
			M.Title LIKE @Name
		) AND MG.GenreName LIKE @MovieGenre
UNION
SELECT * FROM (
	SELECT DP.PersonID, DP.Name
	FROM Movie.Movies M
		LEFT JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
		INNER JOIN Movie.Director D ON D.MovieID = M.MovieID
		INNER JOIN Movie.Person DP ON DP.PersonID = D.PersonID
	WHERE
		(
			DP.[Name] LIKE @Name OR 
			M.Title LIKE @Name
		) AND MG.GenreName LIKE @MovieGenre
) L;