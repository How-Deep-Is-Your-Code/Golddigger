using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Golddiger.Startup))]
namespace Golddiger
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
