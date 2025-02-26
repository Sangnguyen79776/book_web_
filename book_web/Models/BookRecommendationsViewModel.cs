namespace book_web.Models
{
    public class BookRecommendationsViewModel
    {
        public List<Book> BestSellers { get; set; }
        public List<Book> NewReleases { get; set; }
        public List<Book> StaffPicks { get; set; }
    }
}
