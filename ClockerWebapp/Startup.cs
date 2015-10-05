using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ClockerWebapp.Startup))]
namespace ClockerWebapp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            app.MapSignalR();
            ConfigureAuth(app);
        }
    }
}
