using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Juliana_Sosa_Taller1.Models;

namespace Juliana_Sosa_Taller1.Data
{
    public class Juliana_Sosa_Taller1Context : DbContext
    {
        public Juliana_Sosa_Taller1Context (DbContextOptions<Juliana_Sosa_Taller1Context> options)
            : base(options)
        {
        }

        public DbSet<Juliana_Sosa_Taller1.Models.Burger> Burger { get; set; } = default!;
    }
}
