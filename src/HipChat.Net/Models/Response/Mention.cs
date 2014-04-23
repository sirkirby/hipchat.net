using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  [JsonObject]
  public class Mention : Entity
  {      
    [JsonProperty("mention_name")]
    public string MentionName { get; set; }
 
    public Mention()
    {
      Links = new Links();
    }
  }
}