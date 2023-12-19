using collegeApi.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Reflection.Emit;


namespace collegeApi
{
    public class PizzaDbContext:DbContext
    {
        public PizzaDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Pizza> Students { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfigurationsFromAssembly(GetType().Assembly);
            base.OnModelCreating(modelBuilder);
        }
    }
}
