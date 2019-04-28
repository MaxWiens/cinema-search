CREATE OR ALTER PROCEDURE Movie.Search
	@MovieTitle NVARCHAR(512),
	@MovieGenre NVARCHAR(512),
	@PersonName		NVARCHAR(512)
AS
SELECT M.MovieID, M.Title
FROM Movie.Movies M
	LEFT JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
	LEFT JOIN Movie.Director D ON D.MovieID = M.MovieID
	LEFT JOIN Movie.Actor A ON A.MovieID = M.MovieID
	LEFT JOIN Movie.Person PA ON PA.PersonID = A.PersonID
	LEFT JOIN Movie.Person PD ON PD.PersonID = D.PersonID
WHERE 
	M.Title LIKE @MovieTitle AND
	MG.GenreName LIKE @MovieGenre AND 
	(
		PA.Name LIKE @PersonName OR 
		A.CharacterName LIKE @PersonName OR 
		PD.[Name] LIKE @PersonName
	)
;