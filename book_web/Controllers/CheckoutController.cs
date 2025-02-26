using book_web.Models;
using book_web.Services;
using Microsoft.AspNetCore.Mvc;

namespace book_web.Controllers
{
    public class CheckoutController : Controller
    {
        private readonly IOrderService _orderService;
        private readonly IProductService _productService;

        public CheckoutController(IOrderService orderService, IProductService productService)
        {
            _orderService = orderService;
            _productService = productService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var cart = GetCart();
            if (!cart.Items.Any())
            {
                return RedirectToAction("Index", "Cart");
            }

            return View(cart);
        }

        [HttpPost]
        public IActionResult PlaceOrder(Order order)
        {
            if (!ModelState.IsValid)
            {
                return View(order);
            }

            // Get the cart from session and calculate total amount
            var cart = GetCart();
            order.TotalAmount = cart.TotalPrice;

            // Save the order to the database (or in-memory storage)
            var placedOrder = _orderService.PlaceOrder(order);

            // Optionally, you could also perform payment processing here (via third-party APIs like Stripe or PayPal)

            // Clear the cart after the order is placed
            HttpContext.Session.Remove("Cart");

            return RedirectToAction("OrderConfirmation", new { orderId = placedOrder.OrderId });
        }

        private Cart GetCart()
        {
            var cart = HttpContext.Session.GetObject<Cart>("Cart");
            return cart ?? new Cart();
        }
    }

}
