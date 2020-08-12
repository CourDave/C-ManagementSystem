using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_ManagementSystem.Models
{
    public class CustomerModel
    {
        public string firstName { get; set; }
        public string lastName { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
        public string dateRegistered { get; set; }
        public int customerID { get; set; }

    }

}
