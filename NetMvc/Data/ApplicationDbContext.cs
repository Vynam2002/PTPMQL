using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using NetMvc.Models.Entity;

namespace NetMvcData
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<NetMvc.Models.Entity.Student> Student { get; set; } = default!;
         public DbSet<NetMvc.Models.Entity.Person> Person { get; set; } = default!;
    }
}
