using IlyaCourseWork.DB.Entity;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace IlyaCourseWork.DB
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<About> Abouts { get; set; }
        public DbSet<Career> Careers { get; set; }
        public DbSet<Media> Medias { get; set; }
        public DbSet<Products> Productss { get; set; }
    }
}
