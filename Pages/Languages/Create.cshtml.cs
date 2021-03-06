using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectASP.Data;
using ProiectASP.Models;

namespace ProiectASP.Pages.Languages
{
    public class CreateModel : PageModel
    {
        private readonly ProiectASP.Data.ProiectASPContext _context;

        public CreateModel(ProiectASP.Data.ProiectASPContext context)
        {
            _context = context;
        }

        public IActionResult OnGet()
        {
            return Page();
        }

        [BindProperty]
        public Language Language { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Language.Add(Language);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
