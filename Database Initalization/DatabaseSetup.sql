-- Uncomment and run once to create database schema.
-- CREATE SCHEMA Movie;

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
	MovieID INT NOT NULL PRIMARY KEY,
	Title NVARCHAR(512) NOT NULL,
	IsAdult TINYINT,
	Runtime INT,
	ReleaseYear INT
);

CREATE TABLE Movie.Person (
	PersonID INT NOT NULL PRIMARY KEY,
	Name NVARCHAR(128),
	BirthYear INT
);

CREATE TABLE Movie.Genre (
	GenreID INT NOT NULL PRIMARY KEY,
	GenreName NVARCHAR(32) NOT NULL UNIQUE
);

CREATE TABLE Movie.MovieGenre (
	MovieID INT NOT NULL PRIMARY KEY,
	GenreName NVARCHAR(64)
);

CREATE TABLE Movie.Rating (
	MovieID INT NOT NULL PRIMARY KEY,
	Rating NVARCHAR(8) NOT NULL
);

CREATE TABLE Movie.Director (
	MovieID INT NOT NULL,
	PersonID INT NOT NULL PRIMARY KEY
);

CREATE TABLE Movie.Actor (
	MovieID INT NOT NULL,
	PersonID INT NOT NULL,
	CharacterName NVARCHAR(256) NOT NULL
);

CREATE TABLE Movie.MovieRegion (
	MovieID INT NOT NULL PRIMARY KEY,
	RegionName NVARCHAR(64) NOT NULL
);

CREATE TABLE Movie.MovieLanguage (
	MovieID INT NOT NULL PRIMARY KEY,
	LanguageName NVARCHAR(12) NOT NULL
);

CREATE TABLE Movie.Language (
	LanguageID INT NOT NULL PRIMARY KEY,
	LanguageName NVARCHAR(8) NOT NULL UNIQUE
);

CREATE TABLE Movie.Region (
	RegionID INT NOT NULL PRIMARY KEY,
	RegionName NVARCHAR(64) NOT NULL UNIQUE
);
