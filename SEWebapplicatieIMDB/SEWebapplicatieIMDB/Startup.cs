using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SEWebapplicatieIMDB.Startup))]
namespace SEWebapplicatieIMDB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
