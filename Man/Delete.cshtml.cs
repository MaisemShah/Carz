using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CArsssss.Data;

namespace CArsssss.Pages.Man
{
    public class DeleteModel : PageModel
    {
        private readonly CArsssss.Data.ApplicationDbContext _context;

        public DeleteModel(CArsssss.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        [BindProperty]
        public Manufacter Manufacter { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Manufacter = await _context.Manufacter.FirstOrDefaultAsync(m => m.MID == id);

            if (Manufacter == null)
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

            Manufacter = await _context.Manufacter.FindAsync(id);

            if (Manufacter != null)
            {
                _context.Manufacter.Remove(Manufacter);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
