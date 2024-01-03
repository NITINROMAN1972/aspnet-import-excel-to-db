using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Excel_Upload_to_DB.Startup))]
namespace Excel_Upload_to_DB
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
