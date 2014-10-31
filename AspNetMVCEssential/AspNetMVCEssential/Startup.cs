using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AspNetMVCEssential.Startup))]
namespace AspNetMVCEssential
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
