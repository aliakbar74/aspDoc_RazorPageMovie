using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspDoc_RazorPageMovie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace aspDoc_RazorPageMovie.Pages.Books
{ 
    public class CreateModel : PageModel
    {
        private aspDoc_RazorPageMovieContext _db;

        public CreateModel(aspDoc_RazorPageMovieContext db)
        {
            _db = db;
        }
        [BindProperty]
        public Book Book { get; set; }
        public void OnGet()
        {

        }

        public async Task<IActionResult> OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _db.Book.Add(Book);
            await _db.SaveChangesAsync();
            return Page();
        }
    }
}