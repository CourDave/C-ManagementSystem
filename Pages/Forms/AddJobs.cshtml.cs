using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using C_ManagementSystem.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace C_ManagementSystem.Pages.Forms
{
    public class AddJobsModel : PageModel
    {

        [BindProperty]
        public JobModel CustomerJob { get; set; }
        public ContactModel cm { get; set; }

        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            double tax = 0.0888;
            double total = 0;

 
                
            

            if (CustomerJob.NYSTax == true)
            {
                total = CustomerJob.Subtotal - CustomerJob.Discount;
                tax = tax * total;

                total = total + tax;
                CustomerJob.Total = total;
            }
            else
            {
                total = CustomerJob.Subtotal - CustomerJob.Discount;
                CustomerJob.Total = total;
            }


            if (ModelState.IsValid == false)
            {
                return Page();
            }
            return Page();
        }


    }
}