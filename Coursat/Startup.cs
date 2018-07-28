using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Coursat.Startup))]
namespace Coursat
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
