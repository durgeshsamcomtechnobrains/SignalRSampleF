using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;


namespace SignalRSample.Hubs
{
    public class UserActivityHub : Hub
    {
        // Method to send active user list to clients
        public async Task SendActiveUsers(string[] activeUsers)
        {
            await Clients.All.SendAsync("ReceiveActiveUsers", activeUsers);
        }
    }
}
