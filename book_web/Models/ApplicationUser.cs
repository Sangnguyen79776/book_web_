using Microsoft.AspNetCore.Identity;

namespace book_web.Models
{
    public class ApplicationUser :IdentityUser
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
