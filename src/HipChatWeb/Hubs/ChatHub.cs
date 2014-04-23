using System.Threading.Tasks;
using HipChatWeb.Models;
using Microsoft.AspNet.SignalR;

namespace HipChatWeb.Hubs
{
  public class ChatHub : Hub
  {
    /// <summary>
    /// Sends the room message.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <param name="from">From.</param>
    /// <param name="message">The message.</param>
    public void SendRoomMessage(string room, string from, string message)
    {
      Clients.Group(room).roomMessage(room, from, message);
    }

    /// <summary>
    /// Joins the room.
    /// </summary>
    /// <param name="room">The room.</param>
    public async Task JoinRoom(string room)
    {
      await Groups.Add(Context.ConnectionId, room);
    }
  }
}