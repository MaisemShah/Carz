using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using CArsssss.Data;

namespace CArsssss.Pages.Man
{
    public class EditModel : PageModel
    {
        private readonly CArsssss.Data.ApplicationDbContext _context;

        public EditModel(CArsssss.Data.ApplicationDbContext context)
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

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Attach(Manufacter).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!ManufacterExists(Manufacter.MID))
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

        private bool ManufacterExists(int id)
        {
            return _context.Manufacter.Any(e => e.MID == id);
        }
    }
}
