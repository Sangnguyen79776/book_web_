using book_web.Models;

namespace book_web.Services
{
    public interface IOrderService
    {
        Order PlaceOrder(Order order);
        Order GetOrderById(int orderId);
        IEnumerable<Order> GetAllOrders();
    }

}
