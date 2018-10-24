using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(cdnaopsproject.Startup))]
namespace cdnaopsproject
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
