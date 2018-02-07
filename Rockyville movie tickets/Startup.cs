using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(Rockyville_movie_tickets.Startup))]
namespace Rockyville_movie_tickets
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
