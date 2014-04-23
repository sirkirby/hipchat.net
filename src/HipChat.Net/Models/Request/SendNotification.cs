using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChat.Net.Models.Request
{
 [JsonObject]
  public class SendNotification
  {
    [JsonProperty("message")]
    public string Message { get; set; }

    [JsonProperty("color"), JsonConverter(typeof(StringEnumConverter))]
    public MessageColor Color { get; set; }

    [JsonProperty("message_format"), JsonConverter(typeof(StringEnumConverter))]
    public MessageFormat Format { get; set; }

    [JsonProperty("notify")]
    public bool Notify { get; set; }
  }
}
