using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Miniprojekti2.Startup))]
namespace Miniprojekti2
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
