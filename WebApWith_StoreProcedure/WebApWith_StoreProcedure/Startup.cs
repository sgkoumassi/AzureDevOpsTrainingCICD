using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(WebApWith_StoreProcedure.Startup))]
namespace WebApWith_StoreProcedure
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
