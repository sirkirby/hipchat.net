using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  public class RoomItems<TItem>
  {
    [JsonProperty("items")]
    public TItem[] Items { get; set; }

    [JsonProperty("startIndex")]
    public string StartIndex { get; set; }

    [JsonProperty("maxResults")]
    public string MaxResults { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }

    public RoomItems()
    {
      Items = new TItem[] { };
      Links = new Links();
    }
  }
}