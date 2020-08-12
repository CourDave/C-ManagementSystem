using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using C_ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_ManagementSystem.Pages.Forms
{
    public class AddCustomerModel : PageModel
    {
        [BindProperty]
        public CustomerModel CustomerContact { get; set; }
        public JobModel CustomerJob { get; set; }
        public FrameAndLensModel FrameLenses { get; set; }
   
        

    public void OnGet()
        {

        }
        
   
       
        
    }
}
/*
  public IActionResult OnPost()
        {
            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return RedirectToPage("/Index", new { CustomerContact.firstName });
 */
