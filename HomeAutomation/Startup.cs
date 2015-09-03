using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(HomeAutomation.Startup))]
namespace HomeAutomation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
