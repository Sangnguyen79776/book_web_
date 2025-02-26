using book_web.Models;

namespace book_web.Services
{
    public interface IMailService
    {
        bool SendMail(MailData Mail_Data);
    }
}
