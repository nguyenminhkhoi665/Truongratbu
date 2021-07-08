using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Truongratbu.Startup))]
namespace Truongratbu
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
