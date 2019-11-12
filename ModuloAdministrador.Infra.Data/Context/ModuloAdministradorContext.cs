using Microsoft.EntityFrameworkCore;
using ModuloAdministrador.Domain.Entities;
using ModuloAdministrador.Infra.Data.Config;

namespace ModuloAdministrador.Infra.Data.Context {
    public class ModuloAdministradorContext : DbContext {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Estado> Estados { get; set; }
        public DbSet<Municipio> Municipios { get; set; }
        public DbSet<Entidade> Entidades { get; set; }
        public DbSet<UsuarioEntidadePerfil> UsuarioEntidadePerfis { get; set; }
        public DbSet<UsuarioPerfilTipo> UsuarioPerfilTipos { get; set; }
        public DbSet<EntidadeTipo> EntidadeTipos { get; set; }


        public ModuloAdministradorContext(DbContextOptions options): base(options) {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.ApplyConfiguration(new UsuarioMapping());
            base.OnModelCreating(modelBuilder);
        }
    }
}
