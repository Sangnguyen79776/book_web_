using Microsoft.EntityFrameworkCore;

namespace book_web.Models
{

    public class MailData
    {
       
        public string EmailToId { get; set; }
        public string EmailToName { get; set; }
        public string EmailSubject { get; set; }
        public string EmailBody { get; set; }
    }
}
