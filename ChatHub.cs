using Microsoft.AspNetCore.SignalR;

namespace Chat_App.Hubs
{
    public class ChatHub : Hub
    {
        public async Task SendMessage (string user, string meessage)
        {
            Clients.All.SendAsync ("ReceiveMessage",user, meessage);
        }
    }
}
