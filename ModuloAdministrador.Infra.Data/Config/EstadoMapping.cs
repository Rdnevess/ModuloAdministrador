using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuloAdministrador.Domain.Entities;

namespace ModuloAdministrador.Infra.Data.Config {
    class EstadoMapping : IEntityTypeConfiguration<Estado> {
        public void Configure(EntityTypeBuilder<Estado> builder) {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Uf)
                .IsRequired()
                .HasMaxLength(2);

            builder.Property(e => e.Nome)
                .IsRequired()
                .HasMaxLength(60);

            builder.Property(e => e.Ativo).IsRequired();

            builder.HasMany(e => e.Municipios).WithOne(m => m.Estado);

            builder.HasMany(e => e.Entidades).WithOne(m => m.Estado);
        }
    }
}
