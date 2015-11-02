using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(ContactManagerAPI.Startup))]
namespace ContactManagerAPI
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
