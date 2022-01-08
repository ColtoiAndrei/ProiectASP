using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using ProiectASP.Data;
using ProiectASP.Models;

namespace ProiectASP.Pages.Movies
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
            ViewData["GenreID"] = new SelectList(_context.Set<Genre>(), "ID", "GenreName");
            ViewData["DurationID"] = new SelectList(_context.Set<Duration>(), "ID", "DurationName");
            ViewData["LanguageID"] = new SelectList(_context.Set<Language>(), "ID", "LanguageName");
            ViewData["RatingID"] = new SelectList(_context.Set<Rating>(), "ID", "RatingName");
            return Page();
        }

        [BindProperty]
        public Movie Movie { get; set; }

        // To protect from overposting attacks, see https://aka.ms/RazorPagesCRUD
        public async Task<IActionResult> OnPostAsync()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _context.Movie.Add(Movie);
            await _context.SaveChangesAsync();

            return RedirectToPage("./Index");
        }
    }
}
