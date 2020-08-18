using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_ManagementSystem.Models
{
    public class ContactModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
        public string dateRegistered { get; set; }
        public int customerID { get; set; }

    }

    public class JobModel
    {
        public string JobID { get; set; }
        public string CustomerID { get; set; }
        public string JobType { get; set; }
        public string JobDesc { get; set; }
        public string JobDate { get; set; }
        public string FrameDesc { get; set; }
        public string LensDesc { get; set; }
        public int Subtotal { get; set; }
        public int Discount { get; set; }
        public int Total { get { return Subtotal - Discount; } }
        public bool Tax { get; set; }
    }

    public class FrameAndLensModel : JobModel
    {
        public string LensCost { get; set; }
        public string FrameCost { get; set; }
    }
}
