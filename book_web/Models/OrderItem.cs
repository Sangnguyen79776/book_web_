namespace book_web.Models
{
    public class OrderItem
    {
        public int OrderItemId { get; set; }
        public int BookId { get; set; }
       /// <summary>
        //public string Title { get; set; }
       /// </summary>
        public int Quantity { get; set; }
        public double Price { get; set; }
    }
}
