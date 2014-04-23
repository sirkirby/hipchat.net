using HipChat.Net.Http;

namespace HipChat.Net.Clients
{
  public class EmoticonsClient : ApiClient, IEmoticonsClient
  {
    public EmoticonsClient(IApiConnection apiConnection) : base(apiConnection) {}
  }
}
