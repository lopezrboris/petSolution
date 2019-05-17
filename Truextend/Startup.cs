using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Truextend.Startup))]
namespace Truextend
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
