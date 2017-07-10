using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Avipro.Startup))]
namespace Avipro
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
