using Newtonsoft.Json;

namespace HipChat.Net.Models.Response
{
  public class EmoticonItems<TEmoticon>
  {
    [JsonProperty("items")]
    public TEmoticon[] Items { get; set; }

    [JsonProperty("startIndex")]
    public string StartIndex { get; set; }

    [JsonProperty("maxResults")]
    public string MaxResults { get; set; }

    [JsonProperty("links")]
    public Links Links { get; set; }

    public EmoticonItems()
    {
      Items = new TEmoticon[] { };
      Links = new Links();
    }
  }
}