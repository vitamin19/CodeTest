using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CodingTest01.Startup))]
namespace CodingTest01
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
