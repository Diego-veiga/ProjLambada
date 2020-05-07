using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProjLambada.Data
{
    public class LambadaContext :DbContext 
    {

        public LambadaContext(DbContextOptions options):base(options)
        {

        }
    }
}
