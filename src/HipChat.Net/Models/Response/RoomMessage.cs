using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class RoomMessage: WebhookPayload
  {
    [JsonProperty("item")]
    public WebhookItemMessage<Message> Item { get; set; }

    public RoomMessage()
    {
      Item = new WebhookItemMessage<Message>();
    }
  }
}