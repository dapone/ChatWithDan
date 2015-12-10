using Microsoft.Owin;
using Owin;
[assembly: OwinStartup(typeof(ChatWithDan.Startup))]
namespace ChatWithDan
{
    public class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            // Any connection or hub wire up and configuration should go here
            app.MapSignalR();
        }
    }
}