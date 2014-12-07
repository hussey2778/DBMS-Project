using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ConferenceMgmt.Startup))]
namespace ConferenceMgmt
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
