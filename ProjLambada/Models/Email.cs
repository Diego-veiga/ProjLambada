﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjLambada.Models
{
    public class Email
    {
        public int Id { get; set; }
        public string email { get; set; }
        public int TecnicoId { get; set; }

        public  virtual Tecnico Tecnico { get; set; }
    }
}
