using book_web.Data;
using book_web.Models;

namespace book_web.Services
{
    public class EventService : IEventServices
    {
        private readonly Book_webContext _context;
        public EventService(Book_webContext context) { _context = context; }
        public List<Event> GetUpcomingEvents()
        {
            return _context.Events
                .Where(e => e.Date >= DateTime.Now)  // Only future events
                .OrderBy(e => e.Date)
                .ToList();
        }

        // Get all book clubs
        public List<BookClub> GetBookClubs()
        {
            return _context.BookClubs.OrderBy(b => b.MeetingDate).ToList();
        }
    }
}
