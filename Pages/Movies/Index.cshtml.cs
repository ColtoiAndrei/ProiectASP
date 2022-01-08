using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using ProiectASP.Data;
using ProiectASP.Models;

namespace ProiectASP.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly ProiectASP.Data.ProiectASPContext _context;

        public IndexModel(ProiectASP.Data.ProiectASPContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie
                .Include(b=>b.Genre)
                .Include(b=>b.Duration)
                .Include(b=>b.Language)
                .Include(b=>b.Rating)
                .ToListAsync();
        }
    }
}
