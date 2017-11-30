using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WorkEverything.Startup))]
namespace WorkEverything
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
