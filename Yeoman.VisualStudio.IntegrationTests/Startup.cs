using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yeoman.VisualStudio.IntegrationTests.Startup))]
namespace Yeoman.VisualStudio.IntegrationTests
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
