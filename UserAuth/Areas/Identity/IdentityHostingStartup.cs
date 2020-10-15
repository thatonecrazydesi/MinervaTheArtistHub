using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.UI;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using UserAuth.Areas.Identity.Data;
using UserAuth.Data;

[assembly: HostingStartup(typeof(UserAuth.Areas.Identity.IdentityHostingStartup))]
namespace UserAuth.Areas.Identity
{
    public class IdentityHostingStartup : IHostingStartup
    {
        public void Configure(IWebHostBuilder builder)
        {
            builder.ConfigureServices((context, services) => {
                services.AddDbContext<UserAuthDBContext>(options =>
                    options.UseSqlServer(
                        context.Configuration.GetConnectionString("UserAuthDBContextConnection")));

                services.AddDefaultIdentity<MinervaUser>(options => options.SignIn.RequireConfirmedAccount = true)
                    .AddEntityFrameworkStores<UserAuthDBContext>();
            });
        }
    }
}