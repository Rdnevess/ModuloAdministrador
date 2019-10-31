using Microsoft.EntityFrameworkCore;
using ModuloAdministrador.Domain.Entities;

namespace ModuloAdministrador.Infra.Data.Context {
    public class ModuloAdministradorContext : DbContext {
        public DbSet<Entidade> Entidades { get; set; }

        public ModuloAdministradorContext(DbContextOptions options): base(options) {

        }
    }
}
