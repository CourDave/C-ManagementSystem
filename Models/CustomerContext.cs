using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace C_ManagementSystem.Models
{
    public class CustomerContext : DbContext
    {
        public CustomerContext(DbContextOptions options) : base(options) { }
        public DbSet<ContactModel> ContactModels { get; set; }
        public DbSet<JobModel> JobModels { get; set; }
        public DbSet<RxModel> RxModels { get; set; }
        public DbSet<FrameLensModel> FrameLensModels { get; set; }


    }
}
