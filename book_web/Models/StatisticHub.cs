using Microsoft.AspNetCore.SignalR;

namespace book_web.Models
{
    public class StatisticHub :Hub
    {
        public async Task SendStatisticsData(string chartData)
        {
            await Clients.All.SendAsync("ReceiveStatisticsData", chartData);
        }
    }
}
