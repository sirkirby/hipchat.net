using System.Runtime.Serialization;

namespace HipChat.Net.Models.Request
{
  public enum WebhookEvent
  {
    [EnumMember(Value = "room_message")]
    RoomMessage,
    [EnumMember(Value = "room_notification")]
    RoomNotification,
    [EnumMember(Value = "room_exit")]
    RoomExit,
    [EnumMember(Value = "room_enter")]
    RoomEnter,
    [EnumMember(Value = "room_topic_change")]
    RoomTopicChange
  }
}
