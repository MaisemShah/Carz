﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using CArsssss.Data;

namespace CArsssss.Pages.Man
{
    public class IndexModel : PageModel
    {
        private readonly CArsssss.Data.ApplicationDbContext _context;

        public IndexModel(CArsssss.Data.ApplicationDbContext context)
        {
            _context = context;
        }

        public IList<Manufacter> Manufacter { get;set; }

        public async Task OnGetAsync()
        {
            Manufacter = await _context.Manufacter.ToListAsync();
        }
    }
}
