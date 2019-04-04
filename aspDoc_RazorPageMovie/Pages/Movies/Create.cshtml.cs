using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using aspDoc_RazorPageMovie.Models;

namespace aspDoc_RazorPageMovie.Pages.Movies
{
    public class CreateModel : PageModel
    {
        private readonly aspDoc_RazorPageMovie.Models.aspDoc_RazorPageMovieContext _context;

        public CreateModel(aspDoc_RazorPageMovie.Models.aspDoc_RazorPageMovieContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}