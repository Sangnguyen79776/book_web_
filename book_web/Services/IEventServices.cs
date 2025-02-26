using book_web.Models;

namespace book_web.Services
{
    public interface IEventServices
    {
        public List<Event> GetUpcomingEvents();
        public List<BookClub> GetBookClubs();
    }
}
