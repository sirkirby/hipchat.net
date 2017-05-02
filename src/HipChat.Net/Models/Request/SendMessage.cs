using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChat.Net.Models.Request
{

    [JsonObject]
    public class SendMessage
    {
        [JsonProperty("message")]
        public string Message { get; set; }

        [JsonProperty("notify")]
        public bool Notify { get; set; }

        [JsonProperty("message_format"), JsonConverter(typeof(StringEnumConverter))]
        public MessageFormat Format { get; set; }
    }
}