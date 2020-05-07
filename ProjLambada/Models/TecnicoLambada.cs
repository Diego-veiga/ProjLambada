using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjLambada.Models
{
    public class TecnicoLambada
    {
        public int TecnicoId { get; set; }
        public virtual Tecnico Tecnico { get; set; }



        public int LamabdaId { get; set; }
        public virtual Lambada Lambada { get; set; }
    }
}
