using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Golddigger.Startup))]
namespace Golddigger
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
