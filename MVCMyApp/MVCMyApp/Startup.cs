using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCMyApp.Startup))]
namespace MVCMyApp
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
