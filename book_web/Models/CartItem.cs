namespace book_web.Models
{
    public class CartItem
    {
        public int Id { get; set; }
        public int BookId { get; set; }
        public Book Book { get; set; }
        public int Quantity { get; set; }
      //  public double TotalPrice =>Book.BookPrice * Quantity;
      public double Price { get; set; }
    }
}
