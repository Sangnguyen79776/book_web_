using book_web.Models;
using static System.Reflection.Metadata.BlobBuilder;

namespace book_web.Services
{
    public class IBookService
    {
        public string GetDataPath(string file) => $"Data\\{file}";
    
        public void Upload(Book book, IFormFile file)
        {
            if (file != null)
            {
                var path = GetDataPath(file.FileName);
                using var stream = new FileStream(path, FileMode.Create);
                file.CopyTo(stream);
                book.BookCover = file.FileName;
            }
        }
    }
}
