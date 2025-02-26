using book_web.Models;

namespace book_web.Services
{
    public interface IAboutUsService
    {
        public History GetBookstoreHistory();
        public List<TeamMember> GetTeamMembers();
    
    }
}
