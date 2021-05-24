using Microsoft.AspNetCore.Hosting;

[assembly: HostingStartup(typeof(CE.Areas.Identity.IdentityHostingStartup))]
namespace CE.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) =>
            {
            });
        }
    }
}