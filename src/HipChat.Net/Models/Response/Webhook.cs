using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class Webhook
  {
    [JsonProperty("url")]
    public string Url { get; set; }
    
    [JsonProperty("pattern")]
    public string Pattern { get; set; }
    
    [JsonProperty("event")]
    public string Event { get; set; }
    
    [JsonProperty("name")]
    public string Name { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }
  }
}