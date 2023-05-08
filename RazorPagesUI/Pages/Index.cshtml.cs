using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace RazorPagesUI.Pages
{
   public class IndexModel : PageModel
   {
      private readonly ILogger<IndexModel> _logger;

      public IndexModel(ILogger<IndexModel> logger)
      {
         _logger = logger;
      }

      [BindProperty(SupportsGet = true)]//without this SupportsGet --> I can only post.
      public string City { get; set; }

      public void OnGet()
      {
         //So with the return variation II we return an anonomous string object
         // called City which matches up with the name City called out on the ViewModel.
         // After the user types in the whole address because these properties have the exact same 
         // name (Address.City, and Index.City) it should show the city name the user typed in on the
         // Add Address page.
         if (string.IsNullOrEmpty(City))
         {
            City = "The Web";
         }
      }
   }
}
