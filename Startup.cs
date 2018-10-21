using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(FGCSerbiaWeb.Startup))]
namespace FGCSerbiaWeb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
