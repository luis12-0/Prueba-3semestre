using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using _1967955_002_PWEB_Clase.Data;
using _1967955_002_PWEB_Clase.Models;

namespace _1967955_002_PWEB_Clase.Pages.ProductosView
{
    public class IndexModel : PageModel
    {
        private readonly _1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext _context;

        public IndexModel(_1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext context)
        {
            _context = context;
        }

        public IList<Productos> Productos { get;set; }

        public async Task OnGetAsync()
        {
            Productos = await _context.Productos.ToListAsync();
        }
    }
}
