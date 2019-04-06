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
        [TempData]
        public string Message { get; set; }

        [BindProperty]
        public Book Book { get; set; }

        public CreateModel(aspDoc_RazorPageMovieContext db)
        {
            _db = db;
        }
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
            Message = "Book has been created successfuly!";
            return RedirectToPage("./Index");
        }
    }
}