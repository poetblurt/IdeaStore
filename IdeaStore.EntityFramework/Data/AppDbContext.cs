using IdeaStore.Database.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace IdeaStore.Database.Data
{
   public class AppDbContext : IdentityDbContext
   {
      public AppDbContext(DbContextOptions<AppDbContext> options)
          : base(options)
      {
      }

      protected override void OnModelCreating(ModelBuilder builder)
      {
         builder.Entity<Idea>();
         base.OnModelCreating(builder);
      }

      public DbSet<Idea> Ideas { get; set; }
   }
}
