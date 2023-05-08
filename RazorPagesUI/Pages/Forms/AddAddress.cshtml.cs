using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Models;

namespace RazorPagesUI
{
   /// <summary>
   /// We are going to use this page and it's PageModel to show how we post data:
   /// </summary>
    public class AddAddressModel : PageModel
    {
      [BindProperty]
      public AddressModel AddressInsert { get; set; }


        private readonly IAddressRepository _addressRepository;

        public IEnumerable<Address> Addresses { get; set; }

        public AddAddressModel(IAddressRepository addressRepository)
        {

            _addressRepository = addressRepository;

        }

        public void OnGet()
        {

        }

      public IActionResult OnPost()
      {
         //If something is wrong with our values sent in..ergo a blank value was sent.
         if (ModelState.IsValid == false)
         {
            return Page(); //Creates a PageResult value that will rerender the page.
         }

            //NOTE: Here is where you would SAVE MODEL TO DATABASE.
            //NOTE: Here is where you would SAVE MODEL TO DATABASE.
            Address address = new Address
            {

                StreetAddress = AddressInsert.StreetAddress,
                City = AddressInsert.City,
                State = AddressInsert.State,
                ZipCode = AddressInsert.ZipCode
            };

            _addressRepository.Add(address);



            //RETURN VARIATION I:
            //return RedirectToPage("/Index"); // for now lets redirect to the Index page...and at least see this vers
            // of razor .NET Core is /Index (might be different in other versions).

            //RETURN VARIATION II:
            // we are adding the vers. of the function with route Value.
            // also the routeValues arg is an ANONOMOUS object called city.
            // Alternatively we could put City = Address.City but the compiler has the smarts to call
            // City by virtue that the property has the name "City" already.
            return RedirectToPage("/Addresses/Index");
      }
    }
}