using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(AjaxStep.Startup))]
namespace AjaxStep
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
