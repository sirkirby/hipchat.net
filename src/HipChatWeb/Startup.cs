using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(HipChatWeb.Startup))]

namespace HipChatWeb
{
  public partial class Startup
  {
    public void Configuration(IAppBuilder app)
    {
      ConfigureAuth(app);
      app.MapSignalR();
      DoMigrations();
    }
  }
}
