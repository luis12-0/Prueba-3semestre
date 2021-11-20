using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using _1967955_002_PWEB_Clase.Data;
using _1967955_002_PWEB_Clase.Models;

namespace _1967955_002_PWEB_Clase.Pages.ProductosView
{
    public class EditModel : PageModel
    {
        private readonly _1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext _context;

        public EditModel(_1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext context)
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

        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Productos).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ProductosExists(Productos.ID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return RedirectToPage("./Index");
        }

        private bool ProductosExists(int id)
        {
            return _context.Productos.Any(e => e.ID == id);
        }
    }
}
