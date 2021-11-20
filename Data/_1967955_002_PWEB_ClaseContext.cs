using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using _1967955_002_PWEB_Clase.Models;

namespace _1967955_002_PWEB_Clase.Data
{
    public class _1967955_002_PWEB_ClaseContext : DbContext
    {
        public _1967955_002_PWEB_ClaseContext (DbContextOptions<_1967955_002_PWEB_ClaseContext> options)
            : base(options)
        {
        }

        public DbSet<_1967955_002_PWEB_Clase.Models.Productos> Productos { get; set; }
    }
}
