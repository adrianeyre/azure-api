using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(AdrianMobileAppService.Startup))]

namespace AdrianMobileAppService
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureMobileApp(app);
        }
    }
}