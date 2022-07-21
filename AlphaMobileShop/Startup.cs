using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AlphaMobileShop.Startup))]
namespace AlphaMobileShop
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
