using book_web.Data;
using book_web.Models;
using Microsoft.EntityFrameworkCore;

namespace book_web.Services
{
    public class ContentFetchingService : IContentFetchingService
    {
        private readonly Book_webContext _context;

        public ContentFetchingService(Book_webContext context)
        {
            _context = context;
        }

        // Get Articles (Literature posts, interviews, etc.)
        public List<Article> GetArticles(string category = null, int topN = 10)
        {
            var query = _context.Articles.AsQueryable();

            if (!string.IsNullOrEmpty(category))
            {
                query = query.Where(a => a.Category == category);
            }

            return query.OrderByDescending(a => a.DatePosted)
                        .Take(topN)
                        .ToList();
        }
       
        // Get Book Reviews for a specific book
        public List<BookReview> GetBookReviews(int bookId)
        {
            return _context.BookReviews
                           .Where(br => br.BookId == bookId)
                           .OrderByDescending(br => br.DatePosted)
                           .ToList();
        }

        // Get Author information and their Articles
        public Author GetAuthorWithArticles(int authorId)
        {
            return _context.Authors
                           .Include(a => a.Articles)
                           .FirstOrDefault(a => a.Id == authorId);
        }
    }
}
