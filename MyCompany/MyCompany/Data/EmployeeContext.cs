using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace MyCompany.Models
{
    public class EmployeeContext : DbContext
    {
        public EmployeeContext (DbContextOptions<EmployeeContext> options)
            : base(options)
        {
        }

        public DbSet<MyCompany.Models.Employee> Employee { get; set; }

        //Included a second DbSet to also be able to pull data from the table named: Department
        public DbSet<MyCompany.Models.Department> Department { get; set; }
    }
}
