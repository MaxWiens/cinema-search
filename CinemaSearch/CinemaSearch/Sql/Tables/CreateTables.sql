﻿CREATE TABLE Movie.Movies (
	MovieID INT NOT NULL PRIMARY KEY,
	Title NVARCHAR(512) NOT NULL,
	IsAdult TINYINT,
	Runtime INT,
	ReleaseYear INT,
	StudioID INT NOT NULL
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

CREATE TABLE Movie.Studio (
	StudioID INT NOT NULL PRIMARY KEY,
	StudioName NVARCHAR(256) NOT NULL
);