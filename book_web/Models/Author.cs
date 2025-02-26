namespace book_web.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Biography { get; set; } // Short biography
        public string ImageUrl { get; set; } // URL to the author's image
        public List<Article> Articles { get; set; } // List of articles written by the author
    }
}
