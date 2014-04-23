using System;
using System.Threading.Tasks;
using HipChat.Net.Http;
using HipChat.Net.Models.Request;
using HipChat.Net.Models.Response;

namespace HipChat.Net.Clients
{
  public interface IRoomsClient
  {
    /// <summary>
    /// Creates the asynchronous.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="owner">The owner.</param>
    /// <param name="privacy">The privacy.</param>
    /// <param name="guestAccess">if set to <c>true</c> [guest access].</param>
    /// <returns>Task&lt;IResponse&lt;Entity&gt;&gt;.</returns>
    Task<IResponse<Entity>> CreateAsync(string name, string owner, RoomPrivacy privacy = RoomPrivacy.Public, bool guestAccess = false);

    /// <summary>
    /// Updates the asynchronous.
    /// </summary>
    /// <param name="name">The name.</param>
    /// <param name="privacy">The privacy.</param>
    /// <param name="isArchived">if set to <c>true</c> [is archived].</param>
    /// <param name="guestAccess">if set to <c>true</c> [guest access].</param>
    /// <param name="owner">The owner.</param>
    /// <returns>Task&lt;IResponse&lt;System.Boolean&gt;&gt;.</returns>
    Task<IResponse<bool>> UpdateAsync(string name, RoomPrivacy privacy = RoomPrivacy.Public, bool isArchived = false,  bool guestAccess = false, string owner = null);

    /// <summary>
    /// Gets all asynchronous.
    /// </summary>
    /// <returns>Task&lt;IResponse&lt;RoomItems&lt;Entity&gt;&gt;&gt;.</returns>
    Task<IResponse<RoomItems<Entity>>> GetAllAsync();

    /// <summary>
    /// Gets the asynchronous.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <returns>Task&lt;IResponse&lt;Room&gt;&gt;.</returns>
    Task<IResponse<Room>> GetAsync(string room);

    /// <summary>
    /// Gets the members asynchronous.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <returns>Task&lt;IResponse&lt;RoomItems&lt;Mention&gt;&gt;&gt;.</returns>
    Task<IResponse<RoomItems<Mention>>> GetMembersAsync(string room);

    /// <summary>
    /// Sends the notification asynchronous.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <param name="message">The message.</param>
    /// <param name="notifyRoom">if set to <c>true</c> [notify room].</param>
    /// <param name="format">The format.</param>
    /// <param name="color">The color.</param>
    /// <returns>Task&lt;IResponse&lt;System.Boolean&gt;&gt;.</returns>
    Task<IResponse<bool>> SendNotificationAsync(string room, string message, bool notifyRoom = true, MessageFormat format = MessageFormat.Html, MessageColor color = MessageColor.Gray);

    /// <summary>
    /// Sends the notification asynchronous.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <param name="notification">The notification.</param>
    /// <returns>Task&lt;IResponse&lt;System.Boolean&gt;&gt;.</returns>
    Task<IResponse<bool>> SendNotificationAsync(string room, SendNotification notification);

    /// <summary>
    /// Creates the webhook.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <param name="url">The URL.</param>
    /// <param name="webhookEvent">The webhook event.</param>
    /// <param name="name">The name.</param>
    /// <param name="pattern">The pattern.</param>
    /// <returns>Task&lt;IResponse&lt;System.Boolean&gt;&gt;.</returns>
    Task<IResponse<bool>> CreateWebhookAsync(string room, Uri url, WebhookEvent webhookEvent, string name = null, string pattern = null);

    /// <summary>
    /// Creates the webhook asynchronous.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <param name="hook">The hook.</param>
    /// <returns>Task&lt;IResponse&lt;System.Boolean&gt;&gt;.</returns>
    Task<IResponse<bool>> CreateWebhookAsync(string room, CreateWebhook hook);

    /// <summary>
    /// Gets the webhooks.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <returns>Task&lt;IResponse&lt;Room&gt;&gt;.</returns>
    Task<IResponse<RoomItems<Webhook>>> GetWebhooks(string room);

    /// <summary>
    /// Gets the history asynchronous.
    /// </summary>
    /// <param name="room">The room.</param>
    /// <returns>Task&lt;IResponse&lt;RoomItems&lt;Message&gt;&gt;&gt;.</returns>
    Task<IResponse<RoomItems<Message>>> GetHistoryAsync(string room);
  }
}
