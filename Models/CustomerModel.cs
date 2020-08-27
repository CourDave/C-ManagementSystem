using C_ManagementSystem.Pages.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_ManagementSystem.Models
{
        public class ContactModel
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }
            public string DateRegistered { get; set; }
            public int CustomerID { get; set; }
            public string CompanyName { get; set; }

        }

        public class JobModel : ContactModel
        {
                   
            public bool NYSTax { get; set; }
            public string JobID { get; set; }
            public string Lab { get; set; }
            public string JobDesc { get; set; }
            public string JobDate { get; set; }
            public string FrameDesc { get; set; }
            public string AdditionalFrame { get; set; }
            public string LensDesc { get; set; }
            public float Subtotal { get; set; }
            public float Discount { get; set; }
            public double Total { get; set; }
            public string LensCost { get; set; }
            public string FrameCost { get; set; }


    }

        public class RxModel : ContactModel
        {

            public string ODSph { get; set; }
            public string ODCyl { get; set; }
            public string ODAxis { get; set; }
            

            public string OSSph { get; set; }
            public string OSCyl { get; set; }
            public string OSAxis { get; set; }

            public string Pd { get; set; }
            public string Height { get; set; }
            public string AddPower { get; set; }
            public string Notes { get; set; }
    }
}
