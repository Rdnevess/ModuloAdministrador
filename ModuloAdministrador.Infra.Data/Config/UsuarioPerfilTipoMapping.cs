using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuloAdministrador.Domain.Entities;

namespace ModuloAdministrador.Infra.Data.Config {
    class UsuarioPerfilTipoMapping : IEntityTypeConfiguration<UsuarioPerfilTipo> {
        public void Configure(EntityTypeBuilder<UsuarioPerfilTipo> builder) {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Descricao).IsRequired().HasMaxLength(100);
        }
    }
}

//public virtual ICollection<UsuarioEntidadePerfil> UsuarioEntidadePerfis { get; set; }