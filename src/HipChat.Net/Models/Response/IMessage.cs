using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public interface IMessage
  {
    [JsonProperty("color")]
    string Color { get; set; }

    [JsonProperty("date")]
    string Date { get; set; }

    [JsonProperty("id")]
    string Id { get; set; }

    [JsonProperty("mentions")]
    Mention[] Mentions { get; set; }

    [JsonProperty("message")]
    string MessageText { get; set; }

    [JsonProperty("message_format")]
    string Format { get; set; }
  }
}
