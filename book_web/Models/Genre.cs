using System.ComponentModel.DataAnnotations;

namespace book_web.Models
{
    public class Genre
    {
        public int GenreId { get; set; }

        [MinLength(3)]
        [MaxLength(20)]
        public string GenreName { get; set; }

        public ICollection<Book> Books { get; set; }
    }
}
