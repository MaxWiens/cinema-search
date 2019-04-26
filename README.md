Movie.AssociatedMovies

input: personID

output: movieID, movieTitle, [characterName|a character], isDirector


------------------------------------------------------------------------

Movie.AssociatedPeople

input: movieID

output: personID, personName, [characterName|a character]


------------------------------------------------------------------------

Movie.GetDirector

input: movieID
output: personID, personName

--------------------------------------------------------------------
