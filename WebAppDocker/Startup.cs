using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebAppDocker.Startup))]
namespace WebAppDocker
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
