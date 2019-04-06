using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using aspDoc_RazorPageMovie.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;

namespace aspDoc_RazorPageMovie.Pages.Books
{
    public class IndexModel : PageModel
    {
        private readonly aspDoc_RazorPageMovieContext _db;
        public IEnumerable<Book> Books { get; set; }

        [TempData]
        public string Message { get; set; }
        public IndexModel(aspDoc_RazorPageMovieContext db)
        {
            _db = db;
        }
        public async Task OnGet() => Books = await _db.Book.ToListAsync();

        public async Task<IActionResult> OnPostDelete(int id)
        {
            var book =await _db.Book.FindAsync(id);
            _db.Book.Remove(book);
            await _db.SaveChangesAsync();
            Message = "Book has been deleted successfuly!";
            return RedirectToPage("Index");
        }
    }
}