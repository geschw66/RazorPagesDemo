using System.Collections.Generic;

namespace RazorPagesUI.Models
{
   public class SqlAddressRepository : IAddressRepository
   {
      private AppDbContext context;

      public SqlAddressRepository(AppDbContext context)
      {
         this.context = context;
      }

      public Address Add(Address address)
      {
         context.Addresses.Add(address);
         context.SaveChanges(); //Like a commit.

         return address;

      }

      public Address Delete(int id)
      {

         /* Check for record's existance before removing */

            Address address = context.Addresses.Find(id);

         /* IF the address exists it will NOT be null, ELSE the returned value will be null */
         {

            context.Remove(address);
            context.SaveChanges(); //Like a commit.
         }

         return address;
      }

      public IEnumerable<Address> GetAddresses()
      {
         return context.Addresses;
      }

      public Address GetAddress(int id) {

         return context.Addresses.Find(id);
      }

      public Address Update(Address addressChanges)
      {
         var address = context.Addresses.Attach(addressChanges);
         address.State =  Microsoft.EntityFrameworkCore.EntityState.Modified; // Need to tell that it's modified.
         context.SaveChanges();

         return addressChanges; //has to be the address in the args list.

      }
   }
}
