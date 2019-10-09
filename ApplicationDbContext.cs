using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using CArsssss.Data;

namespace CArsssss.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<CArsssss.Data.Cars> Cars { get; set; }
        public DbSet<CArsssss.Data.Manufacter> Manufacter { get; set; }
    }
}
