using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(thHUB.Startup))]
namespace thHUB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
