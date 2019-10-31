using System.Collections.Generic;

namespace ModuloAdministrador.Domain.Entities {
    public class Entidade {
        public int Id { get; set; }
        public int? IdSistemaLegado { get; set; }
        public int EstadoId { get; set; }
        public int? MunicipioId { get; set; }
        public string Nome { get; set; }
        public string Cnpj { get; set; }
        public bool Ativo { get; set; }
        public int EntidadeTipoId { get; set; }
        public int? EntidadeFiscalizadoraId { get; set; }

        public virtual Estado Estado { get; set; }
        public virtual Municipio Municipio { get; set; }
        public virtual EntidadeTipo EntidadeTipo { get; set; }

        public ICollection<UsuarioEntidadePerfil> UsuarioEntidadePerfis { get; set; }
    }
}