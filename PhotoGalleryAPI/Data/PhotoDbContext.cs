using Microsoft.EntityFrameworkCore;
using MinervaDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PhotoGalleryAPI.Data
{
    public class PhotoDbContext:DbContext
    {
        public PhotoDbContext(DbContextOptions<PhotoDbContext>options):base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)   //build relationships with this
        {
            

            // Many-to-many: Photos <-> Genres
            modelBuilder.Entity<PhotoGallery>()
                .HasKey(ca => new { ca.PhotoID, ca.GenreID });

            
        }
        public DbSet<Photo> Photos { get; set; }
        public DbSet<PhotoGenre> Genres { get; set; }

       
    }
}
