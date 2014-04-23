 using System;
 using System.Net.Http;

namespace HipChat.Net.Http
{
  public interface IApiConnection
  {
    /// <summary>
    /// Gets the base address.
    /// </summary>
    /// <value>The base address.</value>
    Uri BaseAddress { get; }

    /// <summary>
    /// Gets or sets the credentials.
    /// </summary>
    /// <value>The credentials.</value>
    Credentials Credentials { get; set; }

    /// <summary>
    /// Gets the client.
    /// </summary>
    /// <value>The client.</value>
    HttpClient Client { get; }
  }
}
