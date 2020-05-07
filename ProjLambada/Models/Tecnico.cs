using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjLambada.Models
{
    public class Tecnico
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string CPF { get; set; }
        public DateTime DataDeNascimento { get; set; }
        public IEnumerable<Email> Emails { get; set; }
        public virtual IEnumerable<TecnicoLambada> TecnicoLambadas { get; set; }
    }
}
