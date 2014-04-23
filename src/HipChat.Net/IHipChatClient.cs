using HipChat.Net.Clients;

namespace HipChat.Net
{
  public interface IHipChatClient
  {
    IRoomsClient Rooms { get; }

    IUsersClient Users { get; }

    IEmoticonsClient Emoticons { get; }

    ICapabilitiesClient Capabilities { get; }
  }
}
