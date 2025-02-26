using book_web.Models;

namespace book_web.Dependency_Injection
{
    public interface IBookRespository
    {
        Task<List<Book>> GetAllBooksAsync();
        Task<Book> GetBookByIdAsync(int id);
        Task UpdateBookStockAsync(int bookId, int quantity);
    }
}
