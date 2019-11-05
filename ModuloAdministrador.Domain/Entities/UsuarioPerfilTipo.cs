using System.Collections.Generic;

namespace ModuloAdministrador.Domain.Entities {
    public class UsuarioPerfilTipo {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<UsuarioEntidadePerfil> UsuarioEntidadePerfis { get; set; }
    }
}