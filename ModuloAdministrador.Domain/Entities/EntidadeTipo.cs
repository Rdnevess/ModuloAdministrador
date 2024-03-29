﻿using System.Collections.Generic;

namespace ModuloAdministrador.Domain.Entities {
    public class EntidadeTipo {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public virtual ICollection<Entidade> Entidades { get; set; }
    }
}