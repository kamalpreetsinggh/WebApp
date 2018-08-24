using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Collections;

namespace Kellton.Models.Details
{
    public class MovieData
    {
        public List<MovieModel> movieList = new List<MovieModel>();

        public void CreateMovie(int movieId, string movieName, string releaseYear, string genre)
        {
            MovieModel movie = new MovieModel
            {
                movieId = movieId,
                movieName = movieName,
                releaseYear = releaseYear,
                genre = genre
            };

            movieList.Add(movie);
        }

        public List<MovieModel> getMovieList()
        {
            CreateMovie(1, "The Pursuit Of Happyness", "Football", "");
            CreateMovie(2, "The Shawshank Redemption", "Football", "");
            CreateMovie(3, "Inception", "Tennis", "");
            CreateMovie(4, "Intersteller", "Tennis", "");
            CreateMovie(5, "The Dark Knight", "Cricket", "");
            CreateMovie(6, "The Wolf Of Wall Street", "Cricket", "");
            CreateMovie(7, "Before Sunset", "Cricket", "");
            CreateMovie(8, "Logan", "Hockey", "");
            CreateMovie(9, "The Prestige", "Swimming", "");
            CreateMovie(10, "The Conjuring", "Wrestling", "");

            return movieList;
        }
    }
}
