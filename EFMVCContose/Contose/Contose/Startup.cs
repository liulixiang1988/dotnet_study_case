using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Contose.Startup))]
namespace Contose
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
