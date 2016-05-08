using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(songforhope.org.Startup))]
namespace songforhope.org
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
