using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GymAlpha.Startup))]
namespace GymAlpha
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
