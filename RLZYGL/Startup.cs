using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(RLZYGL.Startup))]
namespace RLZYGL
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
