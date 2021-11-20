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
    public class DeleteModel : PageModel
    {
        private readonly _1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext _context;

        public DeleteModel(_1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Productos Productos { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Productos = await _context.Productos.FirstOrDefaultAsync(m => m.ID == id);

            if (Productos == null)
            {
                return NotFound();
            }
            return Page();
        }

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Productos = await _context.Productos.FindAsync(id);

            if (Productos != null)
            {
                _context.Productos.Remove(Productos);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
