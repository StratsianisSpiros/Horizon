using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Views.Startup))]
namespace Views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
