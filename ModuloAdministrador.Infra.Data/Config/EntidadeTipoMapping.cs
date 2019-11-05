using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuloAdministrador.Domain.Entities;

namespace ModuloAdministrador.Infra.Data.Config {
    class EntidadeTipoMapping : IEntityTypeConfiguration<EntidadeTipo> {
        public void Configure(EntityTypeBuilder<EntidadeTipo> builder) {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.Id).ValueGeneratedOnAdd();

            builder.Property(e => e.Descricao).HasMaxLength(300);

        }
    }
}