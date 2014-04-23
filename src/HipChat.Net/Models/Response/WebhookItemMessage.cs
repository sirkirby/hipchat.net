using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class WebhookItemMessage<TMessage> : WebhookItem where TMessage : IMessage
  {
    [JsonProperty("message")]
    public TMessage Message { get; set; }
  }
}
