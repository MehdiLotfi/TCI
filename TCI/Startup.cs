using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(TCI.Startup))]
namespace TCI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
