using Microsoft.EntityFrameworkCore;

namespace RazorPagesUI.Models
{
   /// <summary>
   /// This class is an extention class used as a source to create "seed" data
   /// for the Addresses database.
   /// </summary>
   public static class ModelBuilderExtentions
   {
      /// <summary>
      ///  Extention method. This can be called from the AppDbContext class.
      ///  when using the Migration and then Update commands.
      /// </summary>
      public static void Seed(this ModelBuilder modelBuilder)
      {
         modelBuilder.Entity<Address>().HasData(
              new Address
              {
                 Id = 1,
                 StreetAddress = "8822 Delmar Blvd",
                 City = "University City",
                 State = "MO",
                 ZipCode = "63124"
              },
              new Address
              {
                 Id = 2,
                 StreetAddress = "1313 MockingBird Lane",
                 City = "Mockingbird Heights",
                 State = "NH",
                 ZipCode = "30123"
              },

              new Address
              {
                 Id = 3,
                 StreetAddress = "425 Grandview Dr.",
                 City = "Edwardsville",
                 State = "IL",
                 ZipCode = "62025"
              }

           );
      }
   }
}
