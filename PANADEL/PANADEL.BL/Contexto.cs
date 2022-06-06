using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PANADEL.BL
{
    public class Contexto : DbContext
    {
        public Contexto() : base("PANADELDB")
        {

        }

        public DbSet<Producto> productos { get; set; }
    }
}

