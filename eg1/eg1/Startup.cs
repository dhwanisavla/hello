using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(eg1.Startup))]
namespace eg1
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
