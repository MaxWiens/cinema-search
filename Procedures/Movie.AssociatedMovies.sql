/*
INPUT: A person ID.
OUTPUT: The movie IDs, titles, character names, and director credits associated with given person.
*/
CREATE OR ALTER PROCEDURE Movie.AssociatedMovies @personID INT
AS
SELECT
	M.MovieID,
	M.Title, 
	CASE
		WHEN  P.PersonID = A.PersonID AND A.CharacterName != '' THEN A.CharacterName
		WHEN P.PersonID = A.PersonID AND A.CharacterName = '' THEN 'unknown character'
		ELSE NULL
	END AS CharacterName,
	CASE
		WHEN P.PersonID = D.PersonID THEN CAST(1 AS BIT)
		ELSE CAST(0 AS BIT)
	END AS IsDirector
FROM 
	Movie.Movies M
	JOIN Movie.Person P on P.PersonID = @personID
	JOIN Movie.Actor A on A.MovieID = M.MovieID
	JOIN Movie.Director D on D.MovieID = M.MovieID
WHERE P.PersonID = D.PersonID OR P.PersonID = A.PersonID
GROUP BY M.MovieID, M.Title, P.PersonID, A.PersonID, A.CharacterName, D.PersonID;