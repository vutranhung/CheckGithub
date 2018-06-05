using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(CheckGithub.Startup))]
namespace CheckGithub
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
