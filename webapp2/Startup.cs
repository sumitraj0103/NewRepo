using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(webapp2.Startup))]
namespace webapp2
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
