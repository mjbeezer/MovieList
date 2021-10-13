using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace MovieList
{
    class Movie
    {
        //properties
        public string Title;
        public string Category;

        //constructor
        public Movie(string title, string category)
        {
            Title = title;
            Category = category;
        }

        //list of movies
        /*List<Movie> Films = new List<Movie>
            {
            new Movie("Blade", "Horror"),
            new Movie("Tenet", "sciFi"),
            new Movie("Shawshank Redemption", "Drama"),
            new Movie("9", "Animated"),
            new Movie("Blade Runner: 2049", "SciFi"),
            new Movie("Coraline", "Animated"),
            new Movie("Halloween", "Horror"),
            new Movie("Se7en", "Drama"),
            new Movie("Robin Hood","Drama"),
            new Movie("The Thing","Horror")
            };*/

        //method to call movies
        public string GetTitle()
        {
            return Title;
        }

        public string GetCategory()
        {
            return Category;
        }

    }
}