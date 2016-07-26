using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PieceMeal.Startup))]
namespace PieceMeal
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
