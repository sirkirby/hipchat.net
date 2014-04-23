using System;
using System.Net.Http;
using System.Net.Http.Headers;

namespace HipChat.Net.Http
{
  public class ApiConnection : IApiConnection
  {
    public Uri BaseAddress { get; private set; }
    
    public Credentials Credentials { get; set; }

    public HttpClient Client { get; private set; }

    public ApiConnection(Credentials credentials, Uri baseAddress = null)
    {
      BaseAddress = baseAddress;
      Credentials = credentials;

      Client = new HttpClient { BaseAddress = baseAddress ?? new Uri("https://api.hipchat.com/v2/") };
      Client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", credentials.Token);
    }
  }
}
