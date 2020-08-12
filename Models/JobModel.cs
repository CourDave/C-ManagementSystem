using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_ManagementSystem.Models
{
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
        public int Total { get; set; }
        public bool Tax { get; set; }
    }
}
