using Microsoft.EntityFrameworkCore;

namespace book_web.Models
{
    [Keyless]
    public class BookStatisticViewModel
    {
      
         public List<Book> Book {  get; set; }
        public string[] Labels { get; set; } // for the dates
        public int[] Views { get; set; }     // for the views count
        public int[] Sales { get; set; }     // for the sales count
    }
}
