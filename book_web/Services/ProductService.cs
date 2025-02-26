using book_web.Data;
using book_web.Models;

namespace book_web.Services
{
    public class ProductService : IProductService
    {

        private static List<Book> _books = new List<Book>();
        
      
        public Book GetProductById(int bookId)
        {
            return _books.FirstOrDefault(p => p.BookId == bookId);
        }

        public IEnumerable<Book> GetAllProducts()
        {
            return _books;
        }

        public void AddProduct(Book book)
        {
            book.BookId = _books.Max(p => p.BookId) + 1;  // Assign new ID based on the highest existing ID
            _books.Add(book);
        }

        public void UpdateProduct(Book book)
        {
            var existingProduct = _books.FirstOrDefault(p => p.BookId == book.BookId);
            if (existingProduct != null)
            {
                existingProduct.BookTitle = book.BookTitle;
                existingProduct.BookPrice = book.BookPrice;
                existingProduct.BookCover = book.BookCover;
                existingProduct.Author = book.Author;
                existingProduct.Rating = book.Rating;
                existingProduct.SalesCount = book.SalesCount;
              
                existingProduct.GenreId = book.GenreId;
                existingProduct.DateAdded = book.DateAdded;
            }
        }

        public void DeleteProduct(int bookId)
        {
            var product = _books.FirstOrDefault(p => p.BookId == bookId);
            if (product != null)
            {
                _books.Remove(product);
            }
        }
    }
}
