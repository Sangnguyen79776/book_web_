using book_web.Models;

namespace book_web.Services
{
    public interface IBookRecommendationService
    {
        public List<Book> GetBestSellers(int topN=10 );
        public List<Book> GetNewReleases(int topN=10 );
        public List<Book> GetStaffPicks(int topN=10);
    }
}
