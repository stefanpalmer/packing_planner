using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PackingPlanner1.Startup))]
namespace PackingPlanner1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
