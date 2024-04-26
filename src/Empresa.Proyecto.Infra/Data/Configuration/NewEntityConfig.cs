using Microsoft.EntityFrameworkCore;
using Empresa.Proyecto.Core.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Reflection.Emit;

namespace Empresa.Proyecto.Infra.Data.Configuration
{
    internal class NewEntityConfig : IEntityTypeConfiguration<NewEntity>
    {
        public void Configure(EntityTypeBuilder<NewEntity> builder)
        {
            builder.Property(c => c.Nombre)
            .HasMaxLength(50);

            builder
            .HasOne(x => x.Opcion)
            .WithMany(x => x.NewEntities)
            .HasForeignKey(x => x.IdOpcion);
        }
    }
}
