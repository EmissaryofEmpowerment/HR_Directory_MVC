using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace HR_Directory_MVC.Models
{
    public class HR_Directory_MVCContext : DbContext
    {
        public HR_Directory_MVCContext (DbContextOptions<HR_Directory_MVCContext> options)
            : base(options)
        {
        }

        public DbSet<HR_Directory_MVC.Models.Employee> Employee { get; set; }
    }
}
