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
        //public double Total { get { return Subtotal - Discount; } }
        //public double Total { get { return ((Subtotal - Discount) + (Tax * Total)); } }
        // public double Tax { return (0.0888 * Total); } 

    }

        public class FrameAndLensModel : JobModel
        {
            public string LensCost { get; set; }
            public string FrameCost { get; set; }
        }
    }
