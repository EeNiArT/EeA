using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Applaince.Startup))]
namespace Applaince
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
