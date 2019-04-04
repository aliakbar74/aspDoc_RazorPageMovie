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
        
        public IndexModel(aspDoc_RazorPageMovieContext db)
        {
            _db = db;
        }
        public async Task OnGet() => Books = await _db.Book.ToListAsync();
    }
}