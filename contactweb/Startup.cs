using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(contactweb.Startup))]
namespace contactweb
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
