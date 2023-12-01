using Microsoft.EntityFrameworkCore;
using MyBlog.Application.Abstration;
using MyBlog.Domain.Entities;
using MyBlog.Inftastructure.Persistance.EntityTypeConfiguration;

namespace MyBlog.Inftastructure.Persistance
{
    public class ApplicationDbContext : DbContext , IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<Post> Posts { get; set; }

        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    base.OnModelCreating(modelBuilder);

        //    modelBuilder.ApplyConfiguration(new PostEntityTypeConfiguration());
        //}
    }
}
