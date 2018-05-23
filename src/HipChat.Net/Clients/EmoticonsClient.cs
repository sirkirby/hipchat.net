using HipChat.Net.Http;
using HipChat.Net.Models.Response;
using Newtonsoft.Json;
using System.Net;
using System.Threading.Tasks;

namespace HipChat.Net.Clients
{
  public class EmoticonsClient : ApiClient, IEmoticonsClient
  {
    public EmoticonsClient(IApiConnection apiConnection) : base(apiConnection) {}
    
    /// <summary>
    /// Get all emoticons
    /// </summary>
    /// <returns>Task&lt;EmoticonItems&lt;Entity&gt;&gt;.</returns>
    public async Task<IResponse<EmoticonItems<Emoticon>>> GetAllAsync()
    {
      var rawResponse = await ApiConnection.Client.GetStringAsync("emoticon");
      var context = JsonConvert.DeserializeObject<EmoticonItems<Emoticon>>(rawResponse);
      var response = new Response<EmoticonItems<Emoticon>>(context)
      {
        Code = HttpStatusCode.OK,
        Body = rawResponse
      };
      return response;
    }
  }
}
