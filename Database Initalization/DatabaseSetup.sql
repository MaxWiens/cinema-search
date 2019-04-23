DROP TABLE IF EXISTS Movie.MovieStudio;
DROP TABLE IF EXISTS Movie.Movies;
DROP TABLE IF EXISTS Movie.Genre;
DROP TABLE IF EXISTS Movie.MovieGenre;
DROP TABLE IF EXISTS Movie.Director;
DROP TABLE IF EXISTS Movie.Actor;
DROP TABLE IF EXISTS Movie.Person;
DROP TABLE IF EXISTS Movie.Studio;
DROP TABLE IF EXISTS Movie.MPAARating;

-- input: title,rating,runtime,release,desc,country,revenue (once per movie) --
CREATE TABLE Movie.Movies (
	MovieID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Title NVARCHAR(64) NOT NULL,
	MPAARatingID TINYINT,
	Runtime INT,
	ReleaseDate DATE,
	Description VARCHAR(512),
	Country NVARCHAR(8),
	Revenue MONEY
);

-- input: FirstName,LastName (once per person) --
CREATE TABLE Movie.Person (
	PersonID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	FirstName NVARCHAR(64),
	LastName NVARCHAR(64)
);

-- input: GenreName (once per genre) --
CREATE TABLE Movie.Genre (
	GenreID TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	GenreName NVARCHAR(32) NOT NULL UNIQUE
);

-- input: genreID (one per movie, in same order as input for Movie.Movies table) --
CREATE TABLE Movie.MovieGenre (
	MovieID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	GenreID TINYINT NOT NULL PRIMARY KEY
);

-- input: PersonID (one per movie, in same order as input for Movie.Movies table) --
CREATE TABLE Movie.Director (
	MovieID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	PersonID INT NOT NULL PRIMARY KEY
);

-- input: MovieID,personID,CharacterName --
CREATE TABLE Movie.Actor (
	MovieID INT NOT NULL PRIMARY KEY,
	PersonID INT NOT NULL PRIMARY KEY,
	CharacterName NVARCHAR(64) NOT NULL PRIMARY KEY
);

-- input: StudioName (once per studio) --
CREATE TABLE Movie.Studio (
	StudioID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	StudioName NVARCHAR(64) NOT NULL UNIQUE
);

-- input: StudioID (one per movie, in same order as input for Movie.Movies table) --
CREATE TABLE Movie.MovieStudio (
	MovieID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	StudioID INT NOT NULL
);

-- input: RatingName (once per MPAA rating) --
CREATE TABLE Movie.MPAARating (
	MPAARatingID TINYINT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	RatingName NVARCHAR(8) NOT NULL UNIQUE
);