using System.Runtime.Serialization;

namespace HipChat.Net.Models.Request
{
  public enum MessageColor
  {
    [EnumMember(Value = "yellow")]
    Yellow,
    [EnumMember(Value = "red")]
    Red,
    [EnumMember(Value = "green")]
    Green,
    [EnumMember(Value = "purple")]
    Purple,
    [EnumMember(Value = "gray")]
    Gray
  }
}
