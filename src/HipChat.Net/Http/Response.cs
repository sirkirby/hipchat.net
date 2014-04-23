using System.Collections.Generic;
using System.Net;

namespace HipChat.Net.Http
{
  public class Response<TModel> : IResponse<TModel>
  {
    public string ContentType { get; set; }
    public object Body { get; set; }
    public HttpStatusCode Code { get; set; }
    public Dictionary<string, string> Headers { get; set; }
    public TModel Model { get; set; }
    
    public Response(TModel model)
    {
      Model = model;
      Code = HttpStatusCode.OK;
      Headers = new Dictionary<string, string>();
      ContentType = "application/json";
    }
  }
}
