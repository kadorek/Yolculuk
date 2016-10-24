using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Yolculuk.Startup))]
namespace Yolculuk
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
