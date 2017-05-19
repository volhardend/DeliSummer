using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(DeliSummer.Startup))]
namespace DeliSummer
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
