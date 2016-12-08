using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(dictionary.Startup))]
namespace dictionary
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
