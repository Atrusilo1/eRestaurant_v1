using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eResturant.Startup))]
namespace eResturant
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
