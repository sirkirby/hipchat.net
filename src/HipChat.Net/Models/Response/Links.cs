using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class Links
  {
    [JsonProperty("members")]
    public string Members { get; set; }

    [JsonProperty("self")]
    public string Self { get; set; }

    [JsonProperty("webhooks")]
    public string Webhooks { get; set; }

    [JsonProperty("prev")]
    public string Previous { get; set; }

    [JsonProperty("next")]
    public string Next { get; set; }
  }
}