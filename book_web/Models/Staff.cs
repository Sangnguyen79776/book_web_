namespace book_web.Models
{
    public class Staff
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<int> Picks { get; set; } // List of Book IDs recommended by the staff
        public int BookId { get; set; }
        public Book Book { get; set; }
    }
}
