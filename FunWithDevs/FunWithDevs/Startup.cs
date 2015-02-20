using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunWithDevs.Startup))]
namespace FunWithDevs
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
