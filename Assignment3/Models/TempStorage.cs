using System;
using System.Collections.Generic;

namespace Assignment3.Models
{
    public static class TempStorage
    {
        private static List<MovieForm> movies = new List<MovieForm>();

        public static IEnumerable<MovieForm> MovieForms => movies;

        public static void AddMovie(MovieForm movie)
        {
            movies.Add(movie);
        }
    }
}
