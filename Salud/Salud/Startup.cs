using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Salud.Startup))]
namespace Salud
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
