using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ServicioSalud.Startup))]
namespace ServicioSalud
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
