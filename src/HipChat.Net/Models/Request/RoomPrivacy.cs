using System.Runtime.Serialization;

namespace HipChat.Net.Models.Request
{
  public enum RoomPrivacy
  {
    [EnumMember(Value = "public")]
    Public,
    [EnumMember(Value = "private")]
    Private
  }
}
