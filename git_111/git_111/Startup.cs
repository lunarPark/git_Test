using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(git_111.Startup))]
namespace git_111
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
