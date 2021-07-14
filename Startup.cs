using Microsoft.Owin;
using Owin;

[assembly: OwinStartupAttribute(typeof(_1612360017_NguyenThanhDanh.Startup))]
namespace _1612360017_NguyenThanhDanh
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
        }
    }
}
