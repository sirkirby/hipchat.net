using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HipChat.Net.Http;
using HipChat.Net.Models.Response;

namespace HipChat.Net.Clients
{
  public interface IEmoticonsClient
  {
    /// <summary>
    /// Gets all asynchronous.
    /// </summary>
    /// <returns>Task&lt;IResponse&lt;EmoticonItems&lt;Emoticon&gt;&gt;&gt;.</returns>
    Task<IResponse<EmoticonItems<Emoticon>>> GetAllAsync();
  }
}
