CREATE OR ALTER PROCEDURE Movie.Search
	@Name NVARCHAR(512),
	@MovieGenre NVARCHAR(512)
AS
SELECT M.MovieID, M.Title
	FROM Movie.Movies M
		LEFT JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
		LEFT JOIN Movie.Director D ON D.MovieID = M.MovieID
		LEFT JOIN Movie.Actor A ON A.MovieID = M.MovieID
		LEFT JOIN Movie.Person PA ON PA.PersonID = A.PersonID
		LEFT JOIN Movie.Person PD ON PD.PersonID = D.PersonID
		LEFT JOIN Movie.Rating R ON R.MovieID = M.MovieID
	WHERE 
		MG.GenreName LIKE @MovieGenre AND 
		(
			M.Title LIKE @Name OR
			PA.Name LIKE @Name OR 
			A.CharacterName LIKE @Name OR 
			PD.Name LIKE @Name
		)
ORDER BY
	DENSE_RANK() OVER(ORDER BY R.Rating ASC)*2 + DENSE_RANK() OVER(ORDER BY M.ReleaseYear ASC) DESC,
	M.Title ASC
;