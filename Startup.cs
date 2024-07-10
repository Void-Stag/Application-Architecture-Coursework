using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(P2659902___Library_System.Startup))]
namespace P2659902___Library_System
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
