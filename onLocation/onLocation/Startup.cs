using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(onLocation.Startup))]
namespace onLocation
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
