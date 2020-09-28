using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(asmasm.Startup))]
namespace asmasm
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
