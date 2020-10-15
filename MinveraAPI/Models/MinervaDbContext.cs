using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MinveraAPI.Models
{
    public class MinervaDbContext : DbContext
    {
        public MinervaDbContext(DbContextOptions<MinervaDbContext> options) : base(options)
        {

        }
        public DbSet<MinervaUsers> Users{get;set;}// USER TABLE

    }
}
