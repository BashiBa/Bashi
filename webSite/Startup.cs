using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webSite.Startup))]
namespace webSite
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
