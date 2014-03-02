using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ResponsiveUnify.Startup))]
namespace ResponsiveUnify
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
