using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class WebhookPayload
  {
    [JsonProperty("event")]
    public string Event { get; set; }

    [JsonProperty("oauth_client_id")]
    public string OauthClientId { get; set; }

    [JsonProperty("webhook_id")]
    public string WebhookId { get; set; }
  }
}
