namespace book_web.Models
{
    public class Discount
    {
        public int Id { get; set; }
        public decimal DiscountPercentage { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public decimal MinimumAmountSpent { get; set; }
        public int MinimumNumberOfPeople { get; set; }
        public bool IsActive { get; set; }
    }

}
