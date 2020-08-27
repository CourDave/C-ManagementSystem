using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace C_ManagementSystem.Pages.Forms
{
    public class AddPrescriptionModel : PageModel
    {
    
        [BindProperty]
        public RxModel FrameLenses { get; set; }
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {

            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return Page();
        }
    }
}
