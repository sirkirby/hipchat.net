using System;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using HipChat.Net.Models.Response;
using HipChatWeb.Hubs;
using HipChatWeb.Models;
using Microsoft.AspNet.SignalR;

namespace HipChatWeb.Api
{
  [RoutePrefix("api/chat")]
  public class HipChatController : ApiController
  {
    private readonly HipChatDbContext _hipChatWeb;

    public HipChatController(HipChatDbContext hipChatWeb)
    {
      _hipChatWeb = hipChatWeb;
    }

    /// <summary>
    /// Messages the specified message.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <returns>HttpResponseMessage.</returns>
    [HttpPost, Route("message/{room}")]
    public HttpResponseMessage Message(RoomMessage message)
    {
      try
      {
        var hub = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
        hub.Clients.Group(message.Item.Room.Id).roomMessage(message.Item.Room.Id,
          message.Item.Message.From.name ?? "Self",
          message.Item.Message.MessageText,
          message.Item.Message.File != null ? message.Item.Message.File.Url : null);
        
        return Request.CreateResponse(HttpStatusCode.Accepted, true);
      }
      catch (Exception e)
      {
        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
      }
    }

    /// <summary>
    /// Messages the specified message.
    /// </summary>
    /// <param name="message">The message.</param>
    /// <returns>HttpResponseMessage.</returns>
    [HttpPost, Route("notification/{room}")]
    public HttpResponseMessage Notification(RoomNotification message)
    {
      try
      {
        var hub = GlobalHost.ConnectionManager.GetHubContext<ChatHub>();
        hub.Clients.Group(message.Item.Room.Id).roomMessage(message.Item.Room.Id, 
          message.Item.Message.From ?? "Self",
          message.Item.Message.MessageText,
          null);

        return Request.CreateResponse(HttpStatusCode.Accepted, true);
      }
      catch (Exception e)
      {
        return Request.CreateErrorResponse(HttpStatusCode.InternalServerError, e.Message);
      }
    }
  }
}
