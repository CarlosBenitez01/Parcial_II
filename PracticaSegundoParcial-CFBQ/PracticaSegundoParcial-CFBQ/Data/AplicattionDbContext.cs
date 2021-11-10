using Microsoft.EntityFrameworkCore;
using PracticaSegundoParcial_CFBQ.Dominio;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PracticaSegundoParcial_CFBQ.Data
{
    public class AplicattionDbContext : DbContext
    {
        public AplicattionDbContext(DbContextOptions<AplicattionDbContext> options)
            : base(options)
        {

        }
        public DbSet<Students> Students { get; set; }

        public DbSet<Enrollements> Enrollements { get; set; }

        public DbSet<Course> Courses { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }
    }
}
