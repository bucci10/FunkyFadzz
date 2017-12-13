using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FunkyFadz.WebMVC.Startup))]
namespace FunkyFadz.WebMVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
