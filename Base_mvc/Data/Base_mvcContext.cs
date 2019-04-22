using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace Base_mvc.Models
{
    public class Base_mvcContext : DbContext
    {
        public Base_mvcContext (DbContextOptions<Base_mvcContext> options)
            : base(options)
        {
        }

        public DbSet<Base_mvc.Models.Department> Department { get; set; }
    }
}
