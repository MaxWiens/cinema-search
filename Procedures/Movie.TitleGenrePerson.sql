/*
INPUT: A movie title and/or person name and/or genre name.
OUTPUT: The title, ID, adult flag, runtime, release year, and rating of movies matching search criteria.
*/
CREATE OR ALTER PROCEDURE Movie.TitleGenrePerson @title NVARCHAR(256), @personName NVARCHAR(256), @genreName NVARCHAR(32)
AS

IF @title = '' AND @personName = ''
	-- Search by genre --
	SELECT DISTINCT M.Title, M.MovieID, M.IsAdult, M.Runtime, M.ReleaseYear, R.Rating FROM Movie.Movies M
	JOIN Movie.Rating R on R.MovieID = M.MovieID
	JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
	JOIN Movie.Genre G ON G.GenreName = MG.GenreName
	WHERE MG.GenreName = @genreName

ELSE IF @title = '' AND @genreName = ''
	-- Search by person --
	SELECT DISTINCT M.Title, M.MovieID, M.IsAdult, M.Runtime, M.ReleaseYear, R.Rating FROM Movie.Movies M
	JOIN Movie.Rating R on R.MovieID = M.MovieID
	JOIN Movie.Actor A on A.MovieID = M.MovieID
	JOIN Movie.Director D on D.MovieID = M.MovieID
	JOIN Movie.Person P on P.Name = @personName
	WHERE P.PersonID = D.PersonID OR P.PersonID = A.PersonID

ELSE IF @genreName = '' AND @personName = ''
	-- Search by title --
	SELECT DISTINCT M.Title, M.MovieID, M.IsAdult, M.Runtime, M.ReleaseYear, R.Rating FROM Movie.Movies M
	JOIN Movie.Rating R on R.MovieID = M.MovieID
	WHERE M.Title LIKE @title

ELSE IF @title = ''
	-- Search by person/genre --
	SELECT DISTINCT M.Title, M.MovieID, M.IsAdult, M.Runtime, M.ReleaseYear, R.Rating FROM Movie.Movies M
	JOIN Movie.Rating R on R.MovieID = M.MovieID
	JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
	JOIN Movie.Actor A on A.MovieID = M.MovieID
	JOIN Movie.Director D on D.MovieID = M.MovieID
	JOIN Movie.Genre G ON G.GenreName = MG.GenreName
	JOIN Movie.Person P on P.Name = @personName
	WHERE MG.GenreName = @genreName AND (P.PersonID = D.PersonID OR P.PersonID = A.PersonID)

ELSE IF @genreName = ''
	-- Search by person/title --
	SELECT DISTINCT M.Title, M.MovieID, M.IsAdult, M.Runtime, M.ReleaseYear, R.Rating FROM Movie.Movies M
	JOIN Movie.Rating R on R.MovieID = M.MovieID
	JOIN Movie.Actor A on A.MovieID = M.MovieID
	JOIN Movie.Director D on D.MovieID = M.MovieID
	JOIN Movie.Person P on P.Name = @personName
	WHERE M.Title = @title AND (P.PersonID = D.PersonID OR P.PersonID = A.PersonID)

ELSE IF @personName = ''
	-- Search by title/genre --
	SELECT DISTINCT M.Title, M.MovieID, M.IsAdult, M.Runtime, M.ReleaseYear, R.Rating FROM Movie.Movies M
	JOIN Movie.Rating R on R.MovieID = M.MovieID
	JOIN Movie.MovieGenre MG ON MG.MovieID = M.MovieID
	JOIN Movie.Genre G ON G.GenreName = MG.GenreName
	WHERE MG.GenreName = @genreName AND M.Title = @title
;