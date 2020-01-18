using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCPemula.Startup))]
namespace MVCPemula
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
