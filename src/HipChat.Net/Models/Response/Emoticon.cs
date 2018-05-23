using System;
using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class Emoticon : Entity
  {
    [JsonProperty("url")]
    public string Url { get; set; }

    [JsonProperty("self")]
    public string Self { get; set; }

    [JsonProperty("shortcut")]
    public string Shortcut { get; set; }
  }
}
