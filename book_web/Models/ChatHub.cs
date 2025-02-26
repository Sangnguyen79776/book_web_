using Microsoft.AspNetCore.SignalR;

namespace book_web.Models
{
    public class ChatHub :Hub
    {
        //Sending a message to a specific client using its connection ID
        public async Task SendMessageToClient(string connectionId, string message)
        {
        // Send a message to the specific client by its connection ID
        await Clients.Client(connectionId).SendAsync("ReceiveMessage", message);
        }
        public async Task SendMessage(string user, string message)
        {
            // Broadcast the message to all connected clients
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
        public override Task OnConnectedAsync()
        {
            var connectionId = Context.ConnectionId; // Get the Connection ID
            Console.WriteLine($"New connection established. Connection ID: {connectionId}");

            // Optionally, you can store this connection ID in a dictionary or database if you need it for later.

            return base.OnConnectedAsync();
        }

        // This method will be called when a connection is disconnected
        public override Task OnDisconnectedAsync(Exception exception)
        {
            var connectionId = Context.ConnectionId; // Get the Connection ID
            Console.WriteLine($"Connection {connectionId} disconnected.");

            return base.OnDisconnectedAsync(exception);
        }
    }
}
