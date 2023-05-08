using System.Collections;
using System.Collections.Generic;

namespace RazorPagesUI.Models
{
   public interface IAddressRepository
   {


      IEnumerable<Address> GetAddresses();

      Address Add (Address address);

      Address Update (Address addressChanges);

      Address Delete (int id);

   }
}
