using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectASP.Data;
using ProiectASP.Models;

namespace ProiectASP.Pages.Durations
{
    public class DetailsModel : PageModel
    {
        private readonly ProiectASP.Data.ProiectASPContext _context;

        public DetailsModel(ProiectASP.Data.ProiectASPContext context)
        {
            _context = context;
        }

        public Duration Duration { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Duration = await _context.Duration.FirstOrDefaultAsync(m => m.ID == id);

            if (Duration == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
