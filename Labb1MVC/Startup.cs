using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Labb1MVC.Startup))]
namespace Labb1MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
