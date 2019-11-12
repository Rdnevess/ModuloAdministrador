using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuloAdministrador.Domain.Entities;

namespace ModuloAdministrador.Infra.Data.Config {
    class EntidadeMapping : IEntityTypeConfiguration<Entidade> {
        public void Configure(EntityTypeBuilder<Entidade> builder) {
            builder.HasKey(e => e.Id);

            builder.Property(e => e.IdSistemaLegado);

            builder.Property(e => e.EstadoId).IsRequired();

            builder.Property(e => e.MunicipioId);

            builder.Property(e => e.Nome).IsRequired()
                .HasMaxLength(200);

            builder.Property(e => e.Cnpj).IsRequired()
                .HasMaxLength(20);

            builder.Property(e => e.Ativo).IsRequired();

            builder.Property(e => e.EntidadeTipoId).IsRequired();

            builder.Property(e => e.EntidadeFiscalizadoraId);
        }
    }
}