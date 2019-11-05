using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ModuloAdministrador.Domain.Entities;

namespace ModuloAdministrador.Infra.Data.Config {
    class UsuarioEntidadePerfilMapping : IEntityTypeConfiguration<UsuarioEntidadePerfil> {
        public void Configure(EntityTypeBuilder<UsuarioEntidadePerfil> builder) {
            builder.HasKey(u => u.Id);

            builder.Property(u => u.Id).ValueGeneratedOnAdd();

            builder.Property(u => u.UsuarioId).IsRequired();

            builder.Property(u => u.UsuarioPerfilTipoId).IsRequired();

            builder.Property(u => u.EntidadeId);

            builder.Property(u => u.Ativo).IsRequired();

            builder.Property(u => u.DataCadastro).IsRequired();


        }
    }
}



//public virtual Usuario Usuario { get; set; }
//public virtual UsuarioPerfilTipo UsuarioPerfilTipo { get; set; }
//public virtual Entidade Entidade { get; set; }