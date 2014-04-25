namespace HipChatWeb.Models
{
  public class MessageContext
  {
    public string Id { get; set; }
    public string From { get; set; }
    public string Message { get; set; }
    public string Color { get; set; }
    public string FileUrl{ get; set; }
  }
}