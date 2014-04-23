namespace HipChat.Net.Http
{
  public class Credentials
  {
    public string Token { get; set; }

    public Credentials(string token)
    {
      Token = token;
    }
  }
}
