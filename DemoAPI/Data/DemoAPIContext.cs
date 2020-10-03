using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using DemoAPI.Models;

namespace DemoAPI.Data
{
    public class DemoAPIContext : DbContext
    {
        public DemoAPIContext (DbContextOptions<DemoAPIContext> options)
            : base(options)
        {
        }

        public DbSet<DemoAPI.Models.Product> Product { get; set; }

        public DbSet<DemoAPI.Models.Category> Category { get; set; }
    }
}
