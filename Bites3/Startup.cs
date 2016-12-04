using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Bites3.Startup))]
namespace Bites3
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
