using Microsoft.EntityFrameworkCore;
using Empresa.Proyecto.Core.Entities;
using System.Diagnostics.Metrics;
using System.Reflection.Emit;


namespace Empresa.Proyecto.Infra.Data
{
    public class MyProjectContext : DbContext
    {
        /// <summary>
        /// Constructor para DI
        /// </summary>
        /// <param name="options"></param>
        public MyProjectContext(DbContextOptions<MyProjectContext> options) : base(options)
        {

        }

        public DbSet<SimpleEntity> SimpleEntity => Set<SimpleEntity>();
        public DbSet<ComplexEntity> ComplexEntity => Set<ComplexEntity>();
        public DbSet<NewEntity> NewEntity => Set<NewEntity>();

        protected override void OnModelCreating(ModelBuilder builder)
        {           
            builder.ApplyConfigurationsFromAssembly(System.Reflection.Assembly.GetExecutingAssembly());

            builder.Entity<SimpleEntity>().HasData(
               new() { Id = 1, Created = new DateTime(2024, 1, 26), Modified = new DateTime(2024, 1, 29), Name = "Nuevo", Value = "Nuevo"},
               new() { Id = 2, Created = new DateTime(2024, 1, 25), Modified = new DateTime(2024, 1, 28), Name = "Existente", Value = "Existente" },
               new() { Id = 3, Created = new DateTime(2024, 1, 24), Modified = new DateTime(2024, 1, 27), Name = "Reconstruido", Value = "Reconstruido" }
           );
        }
    }
}
