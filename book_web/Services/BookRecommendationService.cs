using book_web.Data;
using book_web.Models;
using Microsoft.EntityFrameworkCore;

namespace book_web.Services
{
    public class BookRecommendationService : IBookRecommendationService
    {
        private readonly Book_webContext _context;
        public BookRecommendationService(Book_webContext context)
        {
            _context = context;
        }
        public List<Book> GetBestSellers(int topN = 10)
        {
            return _context.Book
                .OrderByDescending(b => b.SalesCount)
                .Take(topN)
                .ToList();
        }

        // Get Latest N Books Added
        public List<Book> GetNewReleases(int topN = 10)
        {
            return _context.Book
                .OrderByDescending(b => b.DateAdded)
                .Take(topN)
                .ToList();
        }

        // Get Staff Picks
       public List<Book> GetStaffPicks(int topN = 10)
       {
            var staff = _context.Staff.Include(s => s.Book).ToList();
            var staffPicks = new HashSet<int>();

            foreach (var s in staff)
            {
                staffPicks.UnionWith(s.Picks); // Collect unique staff picks (book IDs)
            }

            return _context.Book
                .Where(b => staffPicks.Contains(b.BookId))
                .Take(topN)
                .ToList();
        }
    }
}
