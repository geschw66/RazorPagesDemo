using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RazorPagesUI.Models;
using System.Collections;
using System.Collections.Generic;

namespace RazorPagesUI.Pages.Employees
{
    public class IndexModel : PageModel

    {
        private readonly IAddressRepository _addressRepository;

        public IEnumerable<Address> Addresses { get; set; }

        public IndexModel(IAddressRepository addressRepository)
        {

            _addressRepository = addressRepository;

        }
        public void OnGet()
        {
            Addresses = _addressRepository.GetAddresses();
        }
    }
}
