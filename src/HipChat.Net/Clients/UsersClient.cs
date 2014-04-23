using HipChat.Net.Http;

namespace HipChat.Net.Clients
{
  public class UsersClient : ApiClient, IUsersClient
  {
    public UsersClient(IApiConnection apiConnection) : base(apiConnection) {}
  }
}
