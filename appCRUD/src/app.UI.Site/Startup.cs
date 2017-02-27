using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(app.UI.Site.Startup))]
namespace app.UI.Site
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
