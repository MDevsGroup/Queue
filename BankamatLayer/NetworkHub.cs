using BusinessLogicLayer.UserDtos;
using Microsoft.AspNetCore.SignalR;

namespace BankamatLayer;

public class NetworkHub : Hub
{
    public async Task JoinNetwork(NetworkUser networkUser)
    {
        await Clients.All.SendAsync("JoinNetwork", networkUser);
    }

    public async Task LeaveNetwork(NetworkUser networkUser)
    {
        await Clients.All.SendAsync("LeaveNetwork", networkUser);
    }

    public async Task Queue(NetworkUser networkUser)
    {
        await Clients.Clients(networkUser.ConnectionId)
                     .SendAsync("Queue", networkUser);
    }
}