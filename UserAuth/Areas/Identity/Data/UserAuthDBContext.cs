using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using UserAuth.Areas.Identity.Data;
using UserAuth.Models;

namespace UserAuth.Data
{
    public class UserAuthDBContext : IdentityDbContext<MinervaUser>
    {
        public UserAuthDBContext(DbContextOptions<UserAuthDBContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);
            // Customize the ASP.NET Identity model and override the defaults if needed.
            // For example, you can rename the ASP.NET Identity table names and more.
            // Add your customizations after calling base.OnModelCreating(builder);
            builder.Entity<ChatRoom>()
                .HasOne<MinervaUser>(u => u.MinervaUser)
                .WithMany(m => m.Messages)
                .HasForeignKey(d => d.UserId);

        }
        public DbSet<ChatRoom> Messages { get; set; }
    }
}
