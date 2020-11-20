using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(UnitTestExample.Test.StartupOwin))]

namespace UnitTestExample.Test
{
    public partial class StartupOwin
    {
        public void Configuration(IAppBuilder app)
        {
            //AuthStartup.ConfigureAuth(app);
        }
    }
}
