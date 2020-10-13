using C_ManagementSystem.Pages.Forms;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
namespace C_ManagementSystem.Models

{
        public class ContactModel
        {
            [Key]
            public int CustomerID { get; set; }
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public string PhoneNumber { get; set; }
            public string EmailAddress { get; set; }
            public DateTime DateRegistered { get; set; }
            public string CompanyName { get; set; }
           

        }
        

        public class JobModel
        {
            [Key]
            public string JobID { get; set; }
            public string CustomerID { get; set; }
            public bool NYSTax { get; set; }
            public string Lab { get; set; }
            public string JobDesc { get; set; }
            public DateTime JobDate { get; set; }
            public string FrameDesc { get; set; }
            public float Subtotal { get; set; }
            public float Discount { get; set; }
            public double Total { get; set; }
    }

        public class RxModel
        {
            [Key]
            public string RxID { get; set; }
            public string CustomerID { get; set; }
            public string ODSph { get; set; }
            public string ODCyl { get; set; }
            public string ODAxis { get; set; }
            public string OSSph { get; set; }
            public string OSCyl { get; set; }
            public string OSAxis { get; set; }
            public string PatientPD { get; set; }
            public string Height { get; set; }
            public string AddPower { get; set; }
            public string TextNotes { get; set; }
            public DateTime Date { get; set; }
    }

    public class FrameLensModel
     {
        [Key]
        public string WoID { get; set; }
        public string FrameDesc { get; set; }
        public string LensType { get; set; }
        public string LensMaterial { get; set; }
        public string LensAddOn { get; set; }
        public string LensCost { get; set; }
        public string FrameCost { get; set; }
        public string Discount { get; set; }
        public string Total { get; set; }

    }
}
