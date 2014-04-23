using HipChat.Net.Http;

namespace HipChat.Net.Clients
{
  public class CapabilitiesClient : ApiClient, ICapabilitiesClient
  {
    public CapabilitiesClient(IApiConnection apiConnection) : base(apiConnection) {}
  }
}
