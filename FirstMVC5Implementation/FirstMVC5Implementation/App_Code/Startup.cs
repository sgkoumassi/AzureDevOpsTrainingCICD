using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FirstMVC5Implementation.Startup))]
namespace FirstMVC5Implementation
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
