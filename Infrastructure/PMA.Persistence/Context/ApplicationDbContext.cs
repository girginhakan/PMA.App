using Microsoft.EntityFrameworkCore;
using PMA.Application.Interfaces.Context;
using PMA.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMA.Persistence.Context
{
    public class ApplicationDbContext : DbContext, IApplicationContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Plant> Plants { get; set; }

        public DbSet<Category> Categories { get; set; }
    }
}
