using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Lab04_NguyenDucDung.Startup))]
namespace Lab04_NguyenDucDung
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
