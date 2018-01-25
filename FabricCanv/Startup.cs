using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FabricCanv.Startup))]
namespace FabricCanv
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
