using System.Collections.Generic;
using System.Net;
using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class Entity
  {
    public string Content { get; set; }
    public HttpStatusCode Code { get; set; }
    public Dictionary<string, string> Headers { get; private set; }

    [JsonProperty("id")]
    public string Id { get; set; }

    [JsonProperty("name")]
    public string Name { get; set; }
    
    [JsonProperty("links")]
    public Links Links { get; set; }
  }
}
