using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(multishopbd.Startup))]
namespace multishopbd
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
