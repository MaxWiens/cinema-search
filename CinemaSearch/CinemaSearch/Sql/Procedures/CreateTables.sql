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
  

CREATE TABLE Movie.Movies (
	MovieID INT PRIMARY KEY,
	Title NVARCHAR(512) NOT NULL,
	IsAdult BIT,
	Runtime INT,
	ReleaseYear INT
);

CREATE TABLE Movie.Person (
	PersonID INT PRIMARY KEY,
	Name NVARCHAR(128),
	BirthYear INT
);

CREATE TABLE Movie.Genre (
	GenreID INT PRIMARY KEY,
	GenreName NVARCHAR(32) NOT NULL UNIQUE
);

CREATE TABLE Movie.MovieGenre (
	MovieID INT NOT NULL PRIMARY KEY,
	GenreName NVARCHAR(32)
);

CREATE TABLE Movie.Rating (
	MovieID INT PRIMARY KEY,
	Rating FLOAT NOT NULL
);

CREATE TABLE Movie.Director (
	MovieID INT PRIMARY KEY,
	PersonID INT,
);

CREATE TABLE Movie.Actor (
	MovieID INT,
	PersonID INT,
	CharacterName NVARCHAR(256) NOT NULL,
	PRIMARY KEY(MovieID, PersonID)
);

CREATE TABLE Movie.MovieRegion (
	MovieID INT PRIMARY KEY,
	RegionName NVARCHAR(64) NOT NULL
);

CREATE TABLE Movie.MovieLanguage (
	MovieID INT PRIMARY KEY,
	LanguageName NVARCHAR(12) NOT NULL
);

CREATE TABLE Movie.Language (
	LanguageID INT PRIMARY KEY,
	LanguageName NVARCHAR(8) NOT NULL UNIQUE
);

CREATE TABLE Movie.Region (
	RegionID INT PRIMARY KEY,
	RegionName NVARCHAR(64) NOT NULL UNIQUE
);