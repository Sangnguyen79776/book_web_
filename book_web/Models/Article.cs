namespace book_web.Models
{
    public class Article
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Content { get; set; } // The main body of the article
        public DateTime DatePosted { get; set; }
        public string Author { get; set; } // The person who wrote the article
        public string Category { get; set; } // E.g., "Literature", "Interview", "Review", etc.
        public int? BookId { get; set; } // Optional: If the article is related to a specific book
        public Book Book { get; set; } // Navigation property (optional)
    }
}
