using Microsoft.EntityFrameworkCore;

namespace book_web.Models
{
    [Keyless]
    public class BookViewModel
    {
     
        public List<Book> Book { get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages { get; set; }
        public string SortOrder { get; set; } // Để lưu thứ tự sắp xếp
        public string SearchString { get; set; }
        public string GenreName { get; set; }
        public List<Genre> Genre {  get; set; }
    }
}
