using book_web.Models;
using Microsoft.AspNetCore.Mvc;

namespace book_web.Services
{
    public interface IProductService
    {
        Book GetProductById(int bookId);
        IEnumerable<Book> GetAllProducts();
        void AddProduct(Book book);
        void UpdateProduct(Book book);
        void DeleteProduct(int bookId);
    }
}
