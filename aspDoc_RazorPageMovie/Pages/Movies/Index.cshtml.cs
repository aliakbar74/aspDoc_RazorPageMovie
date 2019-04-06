using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using aspDoc_RazorPageMovie.Models;

namespace aspDoc_RazorPageMovie.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly aspDoc_RazorPageMovieContext _context;

        public IndexModel(aspDoc_RazorPageMovieContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
