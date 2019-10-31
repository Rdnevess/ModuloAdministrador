using System;

namespace ModuloAdministrador.Domain.Entities {
    public class UsuarioEntidadePerfil {
        public int Id { get; set; }
        public Guid UsuarioId { get; set; }
        public int UsuarioPerfilTipoId { get; set; }
        public int? EntidadeId { get; set; }
        public bool Ativo { get; set; }
        public DateTime DataCadastro { get; set; }


        public Usuario Usuario { get; set; }
        public UsuarioPerfilTipo UsuarioPerfilTipo { get; set; }
        public Entidade Entidade { get; set; }
    }
}