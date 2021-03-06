﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch.Models
{
    class Movie
    {
        int MovieID;
        string Title;
        bool? IsAdult;
        int? Runtime;
        int? ReleaseYear;
        //Genre Genre;
        //Director Director;

        public Movie (int mid, string t, bool? ia, int? rt, int? ry)
        {
            int MovieID = mid;
            string Title = t;
            bool? IsAdult = ia;
            int? Runtime = rt;
            int? ReleaseYear = ry;
        }
    }
    class MovieLanguage
    {
        int LanguageID;
        int MovieID;
    }
    class Language
    {
        int LanguageID;
        string Name;
    }
    class MovieRegion
    {
        int MovieID;
        int RegionID;
    }
    class Region
    {
        int RegionID;
        string Name;
    }

    class Genre
    {
        private Dictionary<string, Genre> _theDict = new Dictionary<string, Genre>();
        // using dict to make sure we dont create duplicate genres
        // need to override constructor
        int GenreID;
        string Name;
    }
    class Person
    {
        int PersonID;
        string Name;
        int? BirthYear;
    }
    class Actor
    {
        int MovieID;
        int PersonID;
        string CharacterName;
    }
    class Director
    {
        int MovieID;
        int PersonID;
    }
}
