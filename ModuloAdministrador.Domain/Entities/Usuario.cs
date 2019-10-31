using System.Collections.Generic;

namespace ModuloAdministrador.Domain.Entities {
    public class Usuario : Entity {
        public string Nome { get; set; }
        public string Email { get; set; }
        public string Cpf { get; set; }
        public string CallbackUrl { get; set; }

        public ICollection<UsuarioEntidadePerfil> UsuarioEntidadePerfis { get; set; }
    }
}