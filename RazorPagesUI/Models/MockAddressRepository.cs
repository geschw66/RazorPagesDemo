using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace RazorPagesUI.Models
{
   /// <summary>
   /// This class is an "in memory" version of the repository.
   /// </summary>
   public class MockAddressRepository: IAddressRepository

   {

      private List<Address> _addressList;

      public MockAddressRepository()
      {
         _addressList = new List<Address>()
         {
            new Address() { Id = 1, StreetAddress = "8822 Delmar Blvd", City = "University City", State = "MO", ZipCode = "63124" },
            new Address() { Id = 2, StreetAddress = "48 Redbud Lane", City = "Glen Carbon", State = "IL", ZipCode = "62034" },
            new Address() { Id = 3, StreetAddress = "425 Grandview Drive", City = "Edewardsville", State = "IL", ZipCode = "62025" },
            new Address() { Id = 4, StreetAddress = "1313 Mockingbird Lane", City = "Mockingbird Heights", State = "NH", ZipCode = "50344" }
         };
      }

      public Address Add(Address address)
      {
         /* Look at the existing list and find the greatest value of Id that exists, then add 1 (one) to create the new record's id */
         address.Id = _addressList.Max(a => a.Id) + 1;

         /* Add the new address to the list. */
         _addressList.Add(address);

         /* return the new address to the calling function */
         return address;
      }

      public Address Delete(int id)
      {
         /* Make sure it exists...*/
         Address address = _addressList.FirstOrDefault(a => a.Id == id);

         if (address != null)
         {
            _addressList.Remove(address);
         }

         return address;
      }

      public IEnumerable<Address> GetAddresses()
      {
         return _addressList;
      }

      public Address Update(Address addressChanges)
      {
         /* Make sure it exists...*/
         Address address = _addressList.FirstOrDefault(a => a.Id == addressChanges.Id);

         if (address != null)
         {
            address.StreetAddress = addressChanges.StreetAddress;
            address.City = addressChanges.City;
            address.State = addressChanges.State;
            address.ZipCode = addressChanges.ZipCode;

         }
         return address;
      }
   }
}
