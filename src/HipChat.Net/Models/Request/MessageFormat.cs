using System.Runtime.Serialization;

namespace HipChat.Net.Models.Request
{
  public enum MessageFormat
  {
    [EnumMember(Value = "html")]
    Html,
    [EnumMember(Value = "text")]
    Text
  }
}
