using System.Configuration;
using book_web.Models;

namespace book_web.Services
{
    public interface ICusService
    {
        public List<FAQ> GetFAQs();
        public ContactInfo GetContactInformation();
    }
}
