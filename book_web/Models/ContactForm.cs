using Microsoft.EntityFrameworkCore;

namespace book_web.Models
{
    [Keyless]
    public class ContactForm
    {
        public string Yourname { get; set; }
        public string Email {get; set; }
        public string Message { get; set; }
    }
}
