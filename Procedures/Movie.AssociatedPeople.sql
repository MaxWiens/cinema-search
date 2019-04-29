/*
INPUT: A movie ID.
OUTPUT: The person IDs, names, and character names of actors associated with given film.
*/
CREATE OR ALTER PROCEDURE Movie.AssociatedPeople @movieID INT
AS
SELECT
	A.PersonID,
	P.Name, 
	CASE
		WHEN  P.PersonID = A.PersonID AND A.CharacterName != '' THEN A.CharacterName
		WHEN P.PersonID = A.PersonID AND A.CharacterName = '' THEN 'unknown character'
		ELSE NULL
	END AS CharacterName
FROM 
	Movie.Movies M
	JOIN Movie.Actor A on A.MovieID = @movieID
	JOIN Movie.Person P on P.PersonID = A.PersonID
	GROUP BY P.PersonID, A.PersonID, P.Name, A.CharacterName;