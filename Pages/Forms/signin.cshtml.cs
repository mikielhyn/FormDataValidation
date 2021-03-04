using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FormDataValidation.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace FormDataValidation.Pages.Forms
{
    public class signinModel : PageModel
    {
        [BindProperty]
       public PersonModel Person { get; set; }
        public void OnGet()
        {

        }

        public ActionResult onPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            return Redirect("/ Index" );
        }
    }
}
