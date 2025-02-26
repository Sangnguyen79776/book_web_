using book_web.Data;
using book_web.Models;
using book_web.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace book_web.Controllers
{
    public class CartController : Controller
    {
        private readonly IProductService _productService;
        private readonly Book_webContext _context;
        public CartController(IProductService productService, Book_webContext context)
        {
            _productService = productService;
            _context = context;
        }
        [Authorize(Roles ="Reader")]
        public IActionResult AddBookToCart(int bookId)
        {

            // Normally, you would retrieve the book from a database
            var book = _context.Book.FirstOrDefault(b => b.BookId == bookId);
            if (book == null)
            {

                return NotFound();


            }


            var cart = GetCart();

            var cartItem = new CartItem
            {
                BookId = book.BookId,
                Price = book.BookPrice,
                Quantity = 1
            };

            cart.AddBookToCart(cartItem);
            SaveCart(cart);

            return RedirectToAction("Index"); // Redirect to cart overview page or wherever you want
        }


        public IActionResult Index()
        {
            var cart = GetCart();
            return View(cart);
        }

        private Cart GetCart()
        {
            // Assuming Cart is stored in session for simplicity
            var cart = HttpContext.Session.GetObject<Cart>("Cart");
            return cart ?? new Cart();
        }

        private void SaveCart(Cart cart)
        {
            HttpContext.Session.SetObject("Cart", cart);
        }
        public void UpdateCartCount(Cart cart)
        {
            // Store the number of items in the cart in the session for quick access
            HttpContext.Session.SetInt32("CartItemCount", cart.Items.Sum(i => i.Quantity));
        }
        public IActionResult GetCartCount()
        {
            var cart = GetCart();
            int itemCount = cart.Items.Sum(i => i.Quantity);
            return Json(itemCount);
        }
        public IActionResult RemoveFromCart(int bookId)
        {
            var cart = GetCart();
            cart.RemoveFromCart(bookId);
            SaveCart(cart);

            return RedirectToAction("Index");
        }
        public IActionResult Checkout()
        {
            var cart = GetCart();

            // Calculate total amount
            double totalAmount = cart.Items.Sum(item => item.Price * item.Quantity);

            var checkoutViewModel = new CheckoutViewModel
            {
                TotalAmount = totalAmount
            };

            return View("Checkout",checkoutViewModel);
        }
        public IActionResult OrderConfirmation(int orderId)
        {
            // Retrieve the order from the database
            var order = _context.Orders
                .Include(o => o.OrderItems)
                .FirstOrDefault(o => o.OrderId == orderId);

            if (order == null)
            {
                return NotFound();  // Return a 404 page if the order is not found
            }

            return View(order);  // This will render the OrderConfirmation.cshtml view
        }

        [HttpPost]
        public async Task<IActionResult> SubmitOrder(CheckoutViewModel model)
        {
            if (ModelState.IsValid)
            {
                var cart = GetCart();

                // Create a new Order
                var order = new Order
                {
                    CustomerName = User.Identity.IsAuthenticated ? User.Identity.Name : "Guest",

                    ShippingAddress = model.ShippingAddress,
                    PaymentMethod = model.PaymentMethod,
                    TotalAmount = model.TotalAmount,
                    OrderDate = DateTime.Now
                };

                // Add the order items
                foreach (var item in cart.Items)
                {
                    var orderItem = new OrderItem
                    {
                        BookId = item.BookId,

                        Quantity = item.Quantity,
                        Price = item.Price
                    };
                    order.OrderItems.Add(orderItem);
                }

                // Save the order and order items to the database
                _context.Orders.Add(order);
                await _context.SaveChangesAsync();

                // Clear the cart after successful checkout
                cart.ClearCart();
                SaveCart(cart);

                return RedirectToAction("OrderConfirmation", new { orderId = order.OrderId });
            }
            // If model is not valid, show the checkout form again
            return View("Checkout", model);

        }
    }
}
