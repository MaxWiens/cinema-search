IF OBJECT_ID('Movie.Movies', 'U') IS NOT NULL 
  DROP TABLE Movie.Movies;

IF OBJECT_ID('Movie.Person', 'U') IS NOT NULL 
  DROP TABLE Movie.Person;
  
IF OBJECT_ID('Movie.Genre', 'U') IS NOT NULL 
  DROP TABLE Movie.Genre;
  
IF OBJECT_ID('Movie.MovieGenre', 'U') IS NOT NULL 
  DROP TABLE Movie.MovieGenre;
  
IF OBJECT_ID('Movie.Director', 'U') IS NOT NULL 
  DROP TABLE Movie.Director;
  
IF OBJECT_ID('Movie.Actor', 'U') IS NOT NULL 
  DROP TABLE Movie.Actor;
  
IF OBJECT_ID('Movie.MovieLanguage', 'U') IS NOT NULL 
  DROP TABLE Movie.MovieLanguage;
  
IF OBJECT_ID('Movie.Language', 'U') IS NOT NULL 
  DROP TABLE Movie.Language;
  
IF OBJECT_ID('Movie.MovieRegion', 'U') IS NOT NULL 
  DROP TABLE Movie.MovieRegion;
  
IF OBJECT_ID('Movie.Rating', 'U') IS NOT NULL 
  DROP TABLE Movie.Rating;
  
IF OBJECT_ID('Movie.Region', 'U') IS NOT NULL 
  DROP TABLE Movie.Region;

IF OBJECT_ID('Movie.Studio', 'U') IS NOT NULL 
  DROP TABLE Movie.Studio;
  