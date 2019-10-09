using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using CArsssss.Data;

namespace CArsssss.Pages.Carz
{
    public class CreateModel : PageModel
    {
        private readonly CArsssss.Data.ApplicationDbContext _context;

        public CreateModel(CArsssss.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Cars Cars { get; set; }

        // To protect from overposting attacks, please enable the specific properties you want to bind to, for
        // more details see https://aka.ms/RazorPagesCRUD.
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Cars.Add(Cars);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
