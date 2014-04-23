using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using HipChat.Net;
using HipChat.Net.Http;
using HipChatWeb.Models;
using Microsoft.AspNet.Identity;

namespace HipChatWeb.Controllers
{
  [Authorize]
  public class HomeController : Controller
  {
    private readonly HipChatDbContext _hipChatDb;
    private ApplicationUserManager _userManager;

    public HomeController(HipChatDbContext hipChatDb, ApplicationUserManager userManager)
    {
      _hipChatDb = hipChatDb;
      _userManager = userManager;
    }

    public async Task<ActionResult> Index()
    {
      var user = await _userManager.FindByIdAsync(User.Identity.GetUserId());
      var hipChat = new HipChatClient(new ApiConnection(new Credentials(user.HipChatPersonalV2Token)));
      var rooms = await hipChat.Rooms.GetAllAsync();

      var contextList = new List<RoomContext>();
      foreach (var r in rooms.Model.Items)
      {
        var context = new RoomContext
        {
          Name = r.Name,
          Id = r.Id,
          MemberCount = r.Links.Members != null ? (await hipChat.Rooms.GetMembersAsync(r.Id)).Model.Items.Count() : 0
        };
        contextList.Add(context);
      }

      return View(contextList);
    }

    /// <summary>
    /// Chats the specified identifier.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <returns>ActionResult.</returns>
    public async Task<ActionResult> Chat(string id)
    {
      var user = await _userManager.FindByIdAsync(User.Identity.GetUserId());
      var hipChat = new HipChatClient(new ApiConnection(new Credentials(user.HipChatPersonalV2Token)));
      var history = await hipChat.Rooms.GetHistoryAsync(id);

      var contextList = history.Model.Items.Select(h => new MessageContext
      {
        Id = h.Id,
        Message = h.MessageText,
        Color = h.Color,
        From = h.From is string ? h.From : h.From.name
      }).ToList();

      ViewBag.roomId = id;
      
      return View(contextList);
    }

    /// <summary>
    /// Sends the notification.
    /// </summary>
    /// <param name="id">The identifier.</param>
    /// <param name="message">The message.</param>
    /// <param name="color">The color.</param>
    /// <returns>Task&lt;JsonResult&gt;.</returns>
    [HttpPost]
    public async Task<JsonResult> SendNotification(string id, string message, string color = "gray")
    {
      var user = await _userManager.FindByIdAsync(User.Identity.GetUserId());
      var hipChat = new HipChatClient(new ApiConnection(new Credentials(user.HipChatPersonalV2Token)));
      await hipChat.Rooms.SendNotificationAsync(id, HttpUtility.HtmlDecode(message));
      return Json(true, JsonRequestBehavior.AllowGet);
    }
  }
}
