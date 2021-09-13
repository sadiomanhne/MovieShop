using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MovieShop.Data;
using MovieShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieShop.ViewComponents
{
    public class SearchMovie : ViewComponent
    {
        private readonly MVCMovieContext _context;

        public SearchMovie(MVCMovieContext context)
        {
            _context = context;
        }

        public async Task<IViewComponentResult> InvokeAsync(
        )
        {
            IQueryable<string> genreQuery = from m in _context.Movie
                                            orderby m.Genre
                                            select m.Genre;

            //-------------------------------------------------------------------------------------
            var movies = from m in _context.Movie
                         select m;
            
            var movieGenreVM = new SearchMovieViewModel
            {
                Genres = new SelectList(await genreQuery.Distinct().ToListAsync()),
                SearchString = "",
                MovieGenre = ""
            };
            return View(movieGenreVM);
        }       

    }
}
