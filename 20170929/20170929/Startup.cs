using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_20170929.Startup))]
namespace _20170929
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
