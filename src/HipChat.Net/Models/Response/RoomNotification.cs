using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class RoomNotification: WebhookPayload
  {
    [JsonProperty("item")]
    public WebhookItemMessage<Notification> Item { get; set; }

    public RoomNotification()
    {
      Item = new WebhookItemMessage<Notification>();
    }
  }
}
