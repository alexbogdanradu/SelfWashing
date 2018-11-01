using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SelfWashing.Startup))]
namespace SelfWashing
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
