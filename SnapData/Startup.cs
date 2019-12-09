using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(SnapData.Startup))]
namespace SnapData
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
