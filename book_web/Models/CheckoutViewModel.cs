namespace book_web.Models
{
    public class CheckoutViewModel
    {
        public string CustomerName { get; set; }
        public string ShippingAddress { get; set; }
        public string PaymentMethod { get; set; }
        
        public double TotalAmount { get; set; }
    }
}
