IF OBJECT_ID('Movie.Studio', 'U') IS NOT NULL 
  DROP TABLE Movie.Studio;

IF OBJECT_ID('Movie.Rating', 'U') IS NOT NULL 
  DROP TABLE Movie.Rating;
	
IF OBJECT_ID('Movie.Director', 'U') IS NOT NULL 
  DROP TABLE Movie.Director;
  
IF OBJECT_ID('Movie.Actor', 'U') IS NOT NULL
  DROP TABLE Movie.Actor;
	
IF OBJECT_ID('Movie.Person', 'U') IS NOT NULL 
  DROP TABLE Movie.Person;

IF OBJECT_ID('Movie.Movies', 'U') IS NOT NULL 
  DROP TABLE Movie.Movies;
  
IF OBJECT_ID('Movie.Genre', 'U') IS NOT NULL 
  DROP TABLE Movie.Genre;
  
CREATE TABLE Movie.Movies (
	MovieID INT PRIMARY KEY,
	Title NVARCHAR(512) NOT NULL,
	IsAdult BIT,
	Runtime INT,
	ReleaseYear INT,
	StudioID INT,
	GenreID INT
);

CREATE TABLE Movie.Person (
	PersonID INT PRIMARY KEY,
	Name NVARCHAR(128),
	BirthYear INT
);

CREATE TABLE Movie.Genre (
	GenreID INT PRIMARY KEY,
	GenreName NVARCHAR(64) NOT NULL UNIQUE
);

CREATE TABLE Movie.Rating (
	MovieID INT PRIMARY KEY,
	Rating FLOAT NOT NULL
	constraint fk_RatingMovie foreign key(MovieID) references Movie.Movies(MovieID)

);

CREATE TABLE Movie.Director (
	MovieID INT PRIMARY KEY,
	PersonID INT
	constraint fk_DirectorMovie foreign key(MovieID) references Movie.Movies(MovieID),
	constraint fk_ActorPerson foreign key(PersonID) references Movie.Person(PersonID)
);

CREATE TABLE Movie.Actor (
	MovieID INT,
	PersonID INT,
	CharacterName NVARCHAR(256) NOT NULL,
	CONSTRAINT fk_ActorMovie foreign key(MovieID) references Movie.Movies(MovieID),
	CONSTRAINT fk_ActorPerson foreign key(PersonID) references Movie.Person(PersonID),
	PRIMARY KEY(MovieID, PersonID)

);

CREATE TABLE Movie.Studio (
	StudioID INT PRIMARY KEY,
	StudioName NVARCHAR(256) NOT NULL
);