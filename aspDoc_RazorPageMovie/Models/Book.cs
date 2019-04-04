using System.ComponentModel.DataAnnotations;

namespace aspDoc_RazorPageMovie.Models
{
    public class Book
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string Author { get; set; }  
    }
}
