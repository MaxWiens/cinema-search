/*
Gets all people that are actors or directors in a film with a Genre similar to 
@MovieGenre and a person name similar to @Name
*/
CREATE OR ALTER PROCEDURE Movie.PersonSearch
	@Name NVARCHAR(512),
	@MovieGenre NVARCHAR(512)
AS
SELECT AP.PersonID, AP.Name
	FROM Movie.Person AP
		LEFT JOIN Movie.Actor A ON A.PersonID = AP.PersonID
		LEFT JOIN Movie.Movies M ON M.MovieID = A.MovieID
		LEFT JOIN Movie.Genre G ON G.GenreID = M.GenreID
	WHERE
		(
			AP.[Name] LIKE @Name OR 
			A.CharacterName LIKE @Name OR
			M.Title LIKE @Name
		) AND G.GenreName LIKE @MovieGenre
UNION
SELECT * FROM (
	SELECT DP.PersonID, DP.Name
	FROM Movie.Person DP
		LEFT JOIN Movie.Director D ON D.PersonID = DP.PersonID
		LEFT JOIN Movie.Movies M ON M.MovieID = D.MovieID
		LEFT JOIN Movie.Genre G ON G.GenreID = M.GenreID
	WHERE
		(
			DP.[Name] LIKE @Name OR 
			M.Title LIKE @Name
		) AND G.GenreName LIKE @MovieGenre
) L;