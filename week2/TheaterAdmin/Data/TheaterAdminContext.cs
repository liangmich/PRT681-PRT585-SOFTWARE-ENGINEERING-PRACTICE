using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using TheaterAdmin.Models;

namespace TheaterAdmin.Data
{
    public class TheaterAdminContext : DbContext
    {
        public TheaterAdminContext (DbContextOptions<TheaterAdminContext> options)
            : base(options)
        {
        }

        public DbSet<TheaterAdmin.Models.Category> Category { get; set; } = default!;
    }
}
