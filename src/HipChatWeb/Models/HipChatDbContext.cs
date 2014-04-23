using Microsoft.AspNet.Identity.EntityFramework;

namespace HipChatWeb.Models
{
  public class HipChatDbContext : IdentityDbContext<ApplicationUser>
  {
    public HipChatDbContext() : base("name=HipChatDbContext", throwIfV1Schema: false) { }

    public static HipChatDbContext Create()
    {
      return new HipChatDbContext();
    }
  }
}
