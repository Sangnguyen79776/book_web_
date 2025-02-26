using book_web.Models;

namespace book_web.Services
{
    public interface IContentFetchingService
    {
        public List<Article> GetArticles(string category = null, int topN = 10);
        public List<BookReview> GetBookReviews(int bookId);
        public Author GetAuthorWithArticles(int authorId);
      // public List<Article> CreateArticles(Article article);
    }
}
