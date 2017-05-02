using System;
using System.Threading.Tasks;
using HipChat.Net.Http;
using HipChat.Net.Models.Request;
using HipChat.Net.Models.Response;

namespace HipChat.Net.Clients
{
    public interface IUsersClient
    {
        /// <summary>
        /// Sends the notification asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="message">The message.</param>
        /// <param name="notifyRoom">if set to <c>true</c> [notify room].</param>
        /// <param name="format">The format.</param>
        /// <param name="color">The color.</param>
        /// <returns>Task&lt;IResponse&lt;System.Boolean&gt;&gt;.</returns>
        Task<IResponse<bool>> SendNotificationAsync(string username, string message, bool notify = true, MessageFormat format = MessageFormat.Html, MessageColor color = MessageColor.Gray);

        /// <summary>
        /// Sends the notification asynchronous.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="notification">The notification.</param>
        /// <returns>Task&lt;IResponse&lt;System.Boolean&gt;&gt;.</returns>
        Task<IResponse<bool>> SendNotificationAsync(string username, SendMessage message);
    }
}
