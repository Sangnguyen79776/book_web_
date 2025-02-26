namespace book_web.Models
{
    public class BookReview
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; } // Navigation property to Book
        public string Reviewer { get; set; } // The person who wrote the review
        public string Content { get; set; } // The main review content
        public DateTime DatePosted { get; set; }
        public int Rating { get; set; } // Rating out of 5
    }
}
