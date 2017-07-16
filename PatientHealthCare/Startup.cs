using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(PatientHealthCare.Startup))]
namespace PatientHealthCare
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
