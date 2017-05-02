using System;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using HipChat.Net.Helpers;
using HipChat.Net.Http;
using HipChat.Net.Models.Request;
using HipChat.Net.Models.Response;
using Newtonsoft.Json;

namespace HipChat.Net.Clients
{
    public class UsersClient : ApiClient, IUsersClient
    {
        private readonly JsonSerializerSettings _jsonSettings;

        public UsersClient(IApiConnection apiConnection) : base(apiConnection)
        {
            _jsonSettings = new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore };
        }

        public async Task<IResponse<bool>> SendNotificationAsync(string username, string message, bool notify = true, MessageFormat format = MessageFormat.Html, MessageColor color = MessageColor.Gray)
        {
            var notification = new SendMessage
            {
                Message = message,
                Notify = notify,
                Format = format
            };

            return await SendNotificationAsync(username, notification);
        }

        public async Task<IResponse<bool>> SendNotificationAsync(string username, SendMessage message)
        {
            Validate.NotNull(message, "SendNotification argument");
            Validate.Length(message.Message, 10000, "Notification Message");

            var json = JsonConvert.SerializeObject(message, Formatting.None, _jsonSettings);

            var payload = new StringContent(json, Encoding.UTF8, "application/json");

            var result = await ApiConnection.Client.PostAsync(string.Format("user/{0}/message", username), payload);
            var content = await result.Content.ReadAsStringAsync();
            var response = new Response<bool>(true)
            {
                Code = result.StatusCode,
                Body = content,
                ContentType = result.Content.Headers.ContentType.MediaType
            };
            return response;
        }
    }
}
