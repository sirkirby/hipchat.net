using HipChat.Net.Clients;
using HipChat.Net.Http;

namespace HipChat.Net
{
  public class HipChatClient : ApiClient, IHipChatClient
  {
    public IRoomsClient Rooms { get; private set; }
    public IUsersClient Users { get; private set; }
    public IEmoticonsClient Emoticons { get; private set; }
    public ICapabilitiesClient Capabilities { get; private set; }

    public HipChatClient(IApiConnection apiConnection) : base(apiConnection)
    {
      Rooms =new RoomsClient(apiConnection);
      Users = new UsersClient(apiConnection);
      Emoticons = new EmoticonsClient(apiConnection);
      Capabilities = new CapabilitiesClient(apiConnection);
    }
  }
}
