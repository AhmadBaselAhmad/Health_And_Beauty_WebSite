using Microsoft.AspNetCore.SignalR;

namespace SignalRChat.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage(string user, string message)
        {
            var xx = "";
            var x = "";
            var xxs = "";
            await Clients.All.SendAsync("ReceiveMessage", user, message);
        }
    }
}
