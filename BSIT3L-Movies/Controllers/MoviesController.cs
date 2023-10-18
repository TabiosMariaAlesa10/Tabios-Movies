 using System;
using BSIT3L_Movies.Models;
using Microsoft.AspNetCore.Mvc;

namespace BSIT3L_Movies.Controllers
{
	public class MoviesController : Controller
    {
        private List<MovieViewModel> _movies;
        public MoviesController()
		{
            // Sample movie data
            _movies = new List<MovieViewModel>
        {
           new MovieViewModel { Id = 1, Name ="Inception", Rating = "4", ReleaseYear = 2010, Genre = "Action/Adventure/Sci-fi",Image = "~/images/inception.jpg"},
            new MovieViewModel { Id = 2, Name = "12 Angry Men", Rating = "5", ReleaseYear = 1957, Genre = "Crime, Drama" , Image = "~/images/12 angry men.jpg" },
            new MovieViewModel { Id = 3, Name = "The God Father", Rating = "5", ReleaseYear = 1972, Genre = "Crime, Drama" ,Image = "~/images/the godfather.jpg" },
            new MovieViewModel { Id = 4, Name = "Schindler's List", Rating = "5", ReleaseYear = 1993, Genre = "Biography, Drama", Image = "~/images/schindler's list.jpg"},
            new MovieViewModel { Id = 5, Name = "Raging Bull", Rating = "4", ReleaseYear = 1980, Genre = "Sport, Drama", Image = "~/images/raging bull.jpg"},
            new MovieViewModel { Id = 6, Name = "Platoon", Rating = "5", ReleaseYear = 1986, Genre = "War, Drama", Image = "~/images/platoon.jpg"},
            new MovieViewModel { Id = 7, Name = "High noon", Rating = "4", ReleaseYear = 1952, Genre = "Drama", Image = "~/images/high noon.jpg"},
            new MovieViewModel { Id = 8, Name = "The Pianist", Rating = "4", ReleaseYear = 2002, Genre = "Music, Drama", Image = "~/images/the pianist.jpg"},
            new MovieViewModel { Id = 9, Name = "Godfellas", Rating = "5", ReleaseYear = 1990, Genre = "Crime, Drama", Image ="~/images/godfellas.jpg" },
            new MovieViewModel { Id = 10, Name = "The Dark knight", Rating = "5", ReleaseYear = 2008, Genre = "Action, Drama", Image = "~/images/the dark knight.jpg" },
            new MovieViewModel { Id = 11, Name = "Slumdog Millionaire ", Rating = "4", ReleaseYear = 2008, Genre = "Romance, Drama", Image = "~/images/slumdog.jpg" },
            new MovieViewModel { Id = 12, Name = "The Prestige", Rating = "5", ReleaseYear = 2006, Genre = "Sci-Fi,Mystery, Drama" , Image = "~/images/the prestige.jpg"},
            new MovieViewModel { Id = 13, Name = "Memento", Rating = "4", ReleaseYear = 2000, Genre = "Action, Drama", Image = "~/images/memento.jpg"    },
            new MovieViewModel { Id = 14, Name = "Sin City", Rating = "5", ReleaseYear = 2005, Genre = "Crime, Thriller", Image = "~/images/sin city.jpg" },
            new MovieViewModel { Id = 15, Name = "City of God", Rating = "5", ReleaseYear = 2002, Genre = "Crime, Drama", Image = "~/images/city of god.jpg" },
        };
        }
        public ActionResult Random()
        {
            var movie = new MovieViewModel() { Name = "Avatar", Rating = "5" };
            return View(movie);
        }
        public ActionResult GetMovie(int id)
        {
            var movie = _movies.Find(m => m.Id == id);
            if (movie == null)
                return NotFound();
            return View(movie);

        }

    }
}



