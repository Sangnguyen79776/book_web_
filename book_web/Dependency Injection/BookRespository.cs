using book_web.Data;
using book_web.Models;
using Microsoft.EntityFrameworkCore;

namespace book_web.Dependency_Injection
{
    public class BookRespository :IBookRespository
    {
        private readonly  Book_webContext _context;
        public BookRespository(Book_webContext context)
        {
            _context = context;
        }

        public async Task<List<Book>> GetAllBooksAsync()
        {
            return await _context.Book.ToListAsync();
        }

        public async Task<Book> GetBookByIdAsync(int id)
        {
            return await _context.Book.FirstOrDefaultAsync(b => b.BookId == id);
        }

        public async Task UpdateBookStockAsync(int bookId, int quantity)
        {
            var book = await _context.Book.FirstOrDefaultAsync(b => b.BookId == bookId);
            if (book != null)
            {
                book.StockQuantity -= quantity;
                book.LastUpdated = DateTime.UtcNow;
                await _context.SaveChangesAsync();
            }
        }

    }
}
