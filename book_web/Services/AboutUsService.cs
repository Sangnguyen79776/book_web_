using book_web.Data;
using book_web.Models;

namespace book_web.Services
{
    public class AboutUsService : IAboutUsService
    {
        private readonly Book_webContext _context;

        public AboutUsService(Book_webContext context)
        {
            _context = context;
        }

        // Get the bookstore history
        public History GetBookstoreHistory()
        {
            return _context.Histories.FirstOrDefault();
        }

        // Get the list of team members
        public List<TeamMember> GetTeamMembers()
        {
            return _context.TeamMembers.OrderBy(t => t.Name).ToList();
        }
    }
}
