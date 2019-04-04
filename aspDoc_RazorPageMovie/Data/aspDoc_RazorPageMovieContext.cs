using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace aspDoc_RazorPageMovie.Models
{
    public class aspDoc_RazorPageMovieContext : DbContext
    {
        public aspDoc_RazorPageMovieContext (DbContextOptions<aspDoc_RazorPageMovieContext> options)
            : base(options)
        {
        }

        public DbSet<Movie> Movie { get; set; }
        public DbSet<Book> Book { get; set; }
    }
}
