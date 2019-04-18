using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaSearch
{
    class Movie
    {
        int MovieID;
        string Title;
        bool IsAdult;
        int Runtime;
        int ReleaseYear;
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
    class MovieGenre
    {
        int MovieID;
        int GenreID;
    }
    class Genre
    {
        int GenreID;
        string Name;
    }
    class Person
    {
        int PersonID;
        string Name;
        int BirthYear;
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
