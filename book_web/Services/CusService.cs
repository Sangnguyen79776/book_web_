using book_web.Data;
using book_web.Models;
using book_web.Services;
using System.Configuration;

public class CusService : ICusService
{
    private readonly Book_webContext _context;

    public CusService(Book_webContext context)
    {
        _context = context;
    }

    // Get all FAQs
    public List<FAQ> GetFAQs()
    {
        return _context.FAQs.OrderBy(f => f.Question).ToList();
    }

    // Get contact information (email, phone, address, etc.)
    public ContactInfo GetContactInformation()
    {
        return _context.ContactInformations.FirstOrDefault();
    }
}

