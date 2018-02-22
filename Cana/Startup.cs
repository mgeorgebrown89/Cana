using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Cana.Startup))]
namespace Cana
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
