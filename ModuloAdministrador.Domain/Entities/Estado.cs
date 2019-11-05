using System.Collections.Generic;

namespace ModuloAdministrador.Domain.Entities {
    public class Estado {
        public int Id { get; set; }
        public string Uf { get; set; }
        public string Nome { get; set; }
        public bool Ativo { get; set; }

        public virtual ICollection<Municipio> Municipios { get; set; }
        public virtual ICollection<Entidade> Entidades { get; set; }

        //public ICollection<EntidadeFiscalizada> EntidadesFiscalizadas { get; set; }
        //public ICollection<EntidadeFiscalizadora> EntidadesFiscalizadoras { get; set; }
    }
}