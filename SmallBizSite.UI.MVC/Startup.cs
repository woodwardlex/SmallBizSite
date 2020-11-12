using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SmallBizSite.UI.MVC.Startup))]
namespace SmallBizSite.UI.MVC
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
