namespace book_web.Models
{
    public class ArticleDetailsViewModel
    {
        public int Id { get; set; }
        public Article Article { get; set; }
        public List<BookReview> Reviews { get; set; }
    }
}
