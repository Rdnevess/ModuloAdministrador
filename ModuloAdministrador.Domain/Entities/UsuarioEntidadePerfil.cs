using System;

namespace ModuloAdministrador.Domain.Entities {
    public class UsuarioEntidadePerfil {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int UsuarioPerfilTipoId { get; set; }
        public int? EntidadeId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }


        public virtual Usuario Usuario { get; set; }
        public virtual UsuarioPerfilTipo UsuarioPerfilTipo { get; set; }
        public virtual Entidade Entidade { get; set; }
    }
}