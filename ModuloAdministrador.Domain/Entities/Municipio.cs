using System.Collections.Generic;

namespace ModuloAdministrador.Domain.Entities {
    public class Municipio {
        public int Id { get; set; }
        public int EstadoId { get; set; }
        public string Nome { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public bool Ativo { get; set; }

        public virtual Estado Estado { get; set; }

        public ICollection<Entidade> Entidades { get; set; }
        //public ICollection<ColaboradorEndereco> ColaboradorEnderecos { get; set; }
    }
}