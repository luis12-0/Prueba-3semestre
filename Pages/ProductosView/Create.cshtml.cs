using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using _1967955_002_PWEB_Clase.Data;
using _1967955_002_PWEB_Clase.Models;

namespace _1967955_002_PWEB_Clase.Pages.ProductosView
{
    public class CreateModel : PageModel
    {
        private readonly _1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext _context;

        public CreateModel(_1967955_002_PWEB_Clase.Data._1967955_002_PWEB_ClaseContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Productos Productos { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Productos.Add(Productos);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
