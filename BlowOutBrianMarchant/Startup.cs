using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BlowOutBrianMarchant.Startup))]
namespace BlowOutBrianMarchant
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
