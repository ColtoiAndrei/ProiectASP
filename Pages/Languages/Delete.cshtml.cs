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
    public class DeleteModel : PageModel
    {
        private readonly ProiectASP.Data.ProiectASPContext _context;

        public DeleteModel(ProiectASP.Data.ProiectASPContext context)
        {
            _context = context;
        }

        [BindProperty]
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

        public async Task<IActionResult> OnPostAsync(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            Language = await _context.Language.FindAsync(id);

            if (Language != null)
            {
                _context.Language.Remove(Language);
                await _context.SaveChangesAsync();
            }

            return RedirectToPage("./Index");
        }
    }
}
