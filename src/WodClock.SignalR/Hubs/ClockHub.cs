using Microsoft.AspNetCore.SignalR;
using System.Threading.Tasks;

namespace WodClock.SignalR.Hubs
{
    public class ClockHub : Hub
    {
        public async Task SendTimer(int msRemaining)
        {
            await Clients.All.SendAsync("ReceiveTimer", msRemaining);
        }
    }
}