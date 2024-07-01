using Microsoft.AspNetCore.SignalR;
using Microsoft.Extensions.Logging;
using System;
using System.Threading.Tasks;

namespace GomokuOnline.Hubs;

internal class GomokuHub(ILogger<GomokuHub> logger) : Hub
{
    private readonly ILogger logger = logger;

    public override Task OnConnectedAsync()
    {
        logger.LogInformation("Player with ID \"{ConnectionId}\" has connected.", Context.ConnectionId);
        return Task.CompletedTask;
    }

    public override Task OnDisconnectedAsync(Exception? exception)
    {
        if (exception is null)
        {
            logger.LogInformation("Player with ID \"{ConnectionId}\" has disconnected.", Context.ConnectionId);
        }
        else
        {
            logger.LogWarning("Player with ID \"{ConnectionId}\" has disconnected with exception {Exception}.", Context.ConnectionId, exception);
        }
        return Task.CompletedTask;
    }
}
