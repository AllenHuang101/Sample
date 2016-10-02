using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CustomModel01.Startup))]
namespace CustomModel01
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
