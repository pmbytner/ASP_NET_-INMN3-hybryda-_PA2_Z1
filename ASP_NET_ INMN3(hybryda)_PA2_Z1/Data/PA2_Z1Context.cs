using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ASP_NET__INMN3_hybryda__PA2_Z1.Models;

namespace ASP_NET__INMN3_hybryda__PA2_Z1.Data
{
    public class PA2_Z1Context : DbContext
    {
        public PA2_Z1Context (DbContextOptions<PA2_Z1Context> options)
            : base(options)
        {
        }

        public DbSet<Miasto> Miasta { get; set; } = default!;
    }
}
