using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class Notification : IMessage
  {
    [JsonProperty("color")]
    public string Color { get; set; }

    [JsonProperty("date")]
    public string Date { get; set; }

    [JsonProperty("from")]
    public string From { get; set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("mentions")]
    public Mention[] Mentions { get; set; }

    [JsonProperty("message")]
    public string MessageText { get; set; }

    [JsonProperty("message_format")]
    public string Format { get; set; }

    public Notification()
    {
      Mentions = new[] { new Mention() };
    }
  }
}