using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(NMedicalCenter.Startup))]
namespace NMedicalCenter
{
    public partial class Startup {
        public void Configuration(IAppBuilder app) {
            ConfigureAuth(app);
        }
    }
}
