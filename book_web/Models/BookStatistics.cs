namespace book_web.Models
{
    public class BookStatistics
    {
        public int Id { get; set; }
      
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Views { get; set; }  // Number of views for the book
        public int Sales { get; set; } // Number of sales for the book
        public DateTime Date { get; set; }

        
    }
}
