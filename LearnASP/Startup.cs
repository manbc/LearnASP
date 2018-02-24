using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(LearnASP.Startup))]
namespace LearnASP
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
