using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Hanxl.Web.Startup))]
namespace Hanxl.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
