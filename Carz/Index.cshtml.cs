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
    public class IndexModel : PageModel
    {
        private readonly CArsssss.Data.ApplicationDbContext _context;

        public IndexModel(CArsssss.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Cars> Cars { get;set; }

        public async Task OnGetAsync()
        {
            Cars = await _context.Cars.ToListAsync();
        }
    }
}
