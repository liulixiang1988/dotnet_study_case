using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MySqlEFDemo.Startup))]
namespace MySqlEFDemo
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
