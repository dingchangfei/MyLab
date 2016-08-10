using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(MyLab.Startup))]
namespace MyLab
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
