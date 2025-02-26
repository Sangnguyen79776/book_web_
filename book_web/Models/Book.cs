
using System.ComponentModel.DataAnnotations;

namespace book_web.Models
{
    public class Book
    {
        public int BookId { get; set; }

        [StringLength(30, ErrorMessage = "Title must be 5 to 30 characters", MinimumLength = 5)]
        public string BookTitle { get; set; }

        [Range(5, 500, ErrorMessage = "Price must be 5$ to 500$")]
        public double BookPrice { get; set; }
        //[FileExtensions(Extensions = "jpg")]
        public string? BookCover { get; set; }
        public string Author { get; set; }
        public double Rating { get; set; }
        public int SalesCount { get; set; }
        public int StockQuantity { get; set; }
        public int GenreId { get; set; }
        public Genre Genre { get; set; }
        public DateTime DateAdded { get; set; }
        public bool IsLimitedEdition { get; set; }
        public DateTime PublishedDate { get; set; }
        public DateTime LastUpdated { get; set; }
       
    }
}
