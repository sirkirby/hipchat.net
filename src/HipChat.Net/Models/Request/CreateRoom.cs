using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace HipChat.Net.Models.Request
{
  [JsonObject]
  public class CreateRoom
  {
    [JsonProperty("name")]
    public string Name { get; set; }
    [JsonProperty("owner_user_id")]
    public string OwnerUserId { get; set; }
    [JsonProperty("guest_access")]
    public bool GuestAccess { get; set; }
    [JsonProperty("privacy"), JsonConverter(typeof(StringEnumConverter))]
    public RoomPrivacy Privacy { get; set; }
  }
}
