using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(EloraCurling.Startup))]
namespace EloraCurling
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
