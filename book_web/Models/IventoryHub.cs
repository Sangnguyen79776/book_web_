using Microsoft.AspNetCore.SignalR;

namespace book_web.Models
{
    public class IventoryHub :Hub
    {
        public async Task NotifyStockUpdate(int bookId)
        {
            await Clients.All.SendAsync("StockUpdated", bookId);
        }
    }
}
