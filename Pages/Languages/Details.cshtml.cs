using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectASP.Data;
using ProiectASP.Models;

namespace ProiectASP.Pages.Languages
{
    public class DetailsModel : PageModel
    {
        private readonly ProiectASP.Data.ProiectASPContext _context;

        public DetailsModel(ProiectASP.Data.ProiectASPContext context)
        {
            _context = context;
        }

        public Language Language { get; set; }

        public async Task<IActionResult> OnGetAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Language = await _context.Language.FirstOrDefaultAsync(m => m.ID == id);

            if (Language == null)
            {
                return NotFound();
            }
            return Page();
        }
    }
}
