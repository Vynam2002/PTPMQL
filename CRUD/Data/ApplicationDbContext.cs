using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DEMO.Models;
using CRUD.Models;

namespace DEMOData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<DEMO.Models.Person> Person { get; set; } = default!;
        public DbSet<CRUD.Models.Employee> Employee { get; set; } = default!;
    }
}
