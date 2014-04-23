using System.Collections.Generic;
using System.Net;

namespace HipChat.Net.Http
{
  public interface IResponse<TModel>
  {
    string ContentType { get; }
    object Body { get; set; }
    HttpStatusCode Code { get; set; }
    Dictionary<string, string> Headers { get; }

    /// <summary>
    /// Gets or sets the model.
    /// </summary>
    /// <value>The model.</value>
    TModel Model { get; set; }
  }
}
