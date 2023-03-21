using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_2011065349TranDinhTho_BigShool.Startup))]
namespace _2011065349TranDinhTho_BigShool
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
