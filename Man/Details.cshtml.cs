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
    public class DetailsModel : PageModel
    {
        private readonly CArsssss.Data.ApplicationDbContext _context;

        public DetailsModel(CArsssss.Data.ApplicationDbContext context)
        {
            _context = context;
        }

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
    }
}
