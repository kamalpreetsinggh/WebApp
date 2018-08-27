using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MovieSearch.Data;
using MovieSearch.Models.Movie;

namespace MovieSearch.Controllers
{
    public class MovieController : Controller
    {
        List<MovieModel> movieList = new List<MovieModel>();

        public IActionResult Index()
        {
            MovieData movieData = new MovieData();
            movieList = movieData.GetMovieList();
            return View(movieList);
        }

        public IActionResult SearchById(int id)
        {
            MovieData movieData = new MovieData();
            var movie = movieData.GetMovieById(id);
            if(movie!=null)
            {
                return PartialView("_MovieByIdViewPartial", movie);
            }
            return NotFound();
        }
    }
}