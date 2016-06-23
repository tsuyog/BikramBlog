using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(BikramBlog.Startup))]
namespace BikramBlog
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
