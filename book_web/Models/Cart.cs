using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace book_web.Models
{
    [Keyless]
    public class Cart
    {
       [Key] public int Id { get; set; }
        public List<CartItem> Items { get; set; } = new List<CartItem>();
        public double TotalPrice => Items.Sum(x => x.Price);

        public void AddBookToCart(CartItem item)
        {
            var existingItem = Items.FirstOrDefault(x => x.BookId == item.BookId);
            if (existingItem != null)
            {
                existingItem.Quantity += item.Quantity;
            }
            else
            {
                Items.Add(item);
            }
        }
        public void RemoveFromCart(int bookId)
        {
            var item = Items.FirstOrDefault(x => x.BookId == bookId);
            if (item != null)
            {
                Items.Remove(item);
            }
        }
        public void ClearCart()
        {
            Items.Clear();
        }
    }
}