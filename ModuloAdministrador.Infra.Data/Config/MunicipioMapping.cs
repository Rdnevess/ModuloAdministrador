using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuloAdministrador.Domain.Entities;

namespace ModuloAdministrador.Infra.Data.Config {
    class MunicipioMapping : IEntityTypeConfiguration<Municipio> {
        public void Configure(EntityTypeBuilder<Municipio> builder) {
            builder.HasKey(m => m.Id);

            builder.Property(m => m.Nome).IsRequired().HasMaxLength(200);

            builder.Property(m => m.Latitude).IsRequired().HasMaxLength(50);

            builder.Property(m => m.Longitude).IsRequired().HasMaxLength(50);

            builder.Property(m => m.Ativo).IsRequired();

            builder.Property(m => m.EstadoId).IsRequired();

            builder.HasMany(m => m.Entidades).WithOne(e => e.Municipio);
        }
    }
}
