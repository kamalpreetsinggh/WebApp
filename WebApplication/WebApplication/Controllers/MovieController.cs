using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Kellton.Models.Details;

namespace Kellton.WebApplication.Controllers
{
    public class MovieController: Controller
    {
        List<MovieModel> movieList = new List<MovieModel>();

        public IActionResult Index()
        {
            MovieData movieData = new MovieData();
            movieList=movieData.getMovieList();
            return View(movieList);
        }
    }
}