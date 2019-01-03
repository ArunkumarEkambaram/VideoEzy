using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(VideoEzy_MVC.Startup))]
namespace VideoEzy_MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
