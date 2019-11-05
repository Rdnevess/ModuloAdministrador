using System.Collections.Generic;

namespace ModuloAdministrador.Domain.Entities {
    public class Usuario {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }

        public virtual ICollection<UsuarioEntidadePerfil> UsuarioEntidadePerfis { get; set; }
    }
}