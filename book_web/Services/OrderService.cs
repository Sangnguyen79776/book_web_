using book_web.Data;
using book_web.Models;

namespace book_web.Services
{
    public class OrderService : IOrderService
    {
        private readonly Book_webContext _context;

        public OrderService(Book_webContext context)
        {
            _context = context;
        }

        public Order PlaceOrder(Order order)
        {
            order.OrderDate = DateTime.Now;

            // Save the order to the database
            _context.Orders.Add(order);
            _context.SaveChanges();

            return order;
        }

        public Order GetOrderById(int orderId)
        {
            return _context.Orders.FirstOrDefault(o => o.OrderId == orderId);
        }

        public IEnumerable<Order> GetAllOrders()
        {
            return _context.Orders.ToList();
        }
    }

}
