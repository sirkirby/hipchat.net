using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  public class WebhookItem
  {
    [JsonProperty("room")]
    public Entity Room { get; set; }
  }
}
