using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SocialNetWork.Startup))]
namespace SocialNetWork
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
