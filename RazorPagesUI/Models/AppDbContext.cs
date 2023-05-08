using Microsoft.EntityFrameworkCore;

namespace RazorPagesUI.Models
{
   public class AppDbContext: DbContext
   {

      public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
      { 
         
      }

      public DbSet<Address> Addresses { get; set; }

      protected override void OnModelCreating(ModelBuilder modelBuilder)
      {
         ///base.OnModelCreating(modelBuilder); // Not using the base class.

         /** 
          * Create seed data here
          *   Encapsulate a list in the static class ModelBuilderExtentions.
          */
         ModelBuilderExtentions.Seed(modelBuilder);

      }


   }
}
