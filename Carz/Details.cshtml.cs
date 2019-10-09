using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CArsssss.Data;

namespace CArsssss.Pages.Carz
{
    public class DetailsModel : PageModel
    {
        private readonly CArsssss.Data.ApplicationDbContext _context;

        public DetailsModel(CArsssss.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public Cars Cars { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Cars = await _context.Cars.FirstOrDefaultAsync(m => m.CID == id);

            if (Cars == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
