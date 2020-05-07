﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjLambada.Models
{
    public class Lambada
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public DateTime DataLambada { get; set; }
        public virtual IEnumerable<TecnicoLambada> TecnicoLambadas { get; set; }

    }
}
