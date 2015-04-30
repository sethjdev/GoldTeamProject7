using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(GoldTeamProject7.Startup))]
namespace GoldTeamProject7
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
