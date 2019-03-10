using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Seis.backend.Startup))]
namespace Seis.backend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
