using System;
using System.Collections.Generic;
using System.Linq;

namespace MovieList
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my movies!");
            //list of movies
            List<Movie> Films = new List<Movie>
            {
            new Movie("Blade", "Horror"),
            new Movie("Tenet", "SciFi"),
            new Movie("Shawshank Redemption", "Drama"),
            new Movie("9", "Animated"),
            new Movie("Blade Runner: 2049", "SciFi"),
            new Movie("Coraline", "Animated"),
            new Movie("Halloween", "Horror"),
            new Movie("Se7en", "Drama"),
            new Movie("Robin Hood","Drama"),
            new Movie("The Thing","Horror")
            };
            bool runProgram = true;
            bool keepGoing = true;

            while (runProgram == true)
            {
                Console.WriteLine("Please choose one of the following categories: Animated, Drama, Horror or SciFi");//this is wrong and I was too frustrated to keep trying to fix it.
                List<Movie> Selected = new List<Movie>();
                string choice = Console.ReadLine();
                foreach (Movie i in Films)
                {
                    if (choice == i.Category)
                    {
                        Selected.Add(i);
                        foreach (Movie m in Selected)
                        {
                            Console.WriteLine($"{m.Title} {m.Category}");
                        }
                    }
                }

                while (keepGoing == true)
                {
                    Console.WriteLine("Would you like to choose another category? y/n");
                    string result = Console.ReadLine().ToLower().Trim();
                    if (result == "y")
                    {
                        keepGoing = true;
                        runProgram = true;
                        break;
                    }
                    else if (result == "n")
                    {
                        keepGoing = false;
                        runProgram = false;
                        break;
                    }
                    else
                    {
                        Console.WriteLine("That was not a valid input.");
                    }
                }
            }
        }
    }
}
