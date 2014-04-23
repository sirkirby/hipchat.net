using HipChat.Net.Http;

namespace HipChat.Net.Clients
{
  /// <summary>
  /// Class ApiClient.
  /// </summary>
  public abstract class ApiClient
  {

    /// <summary>
    /// Initializes a new instance of the <see cref="ApiClient"/> class.
    /// </summary>
    /// <param name="apiConnection">The API connection.</param>
    protected ApiClient(IApiConnection apiConnection)
    {
      ApiConnection = apiConnection;
    }

    /// <summary>
    /// Gets the API connection.
    /// </summary>
    /// <value>The API connection.</value>
    protected IApiConnection ApiConnection { get; private set; }
  }
}
