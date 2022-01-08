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
    public class IndexModel : PageModel
    {
        private readonly ProiectASP.Data.ProiectASPContext _context;

        public IndexModel(ProiectASP.Data.ProiectASPContext context)
        {
            _context = context;
        }

        public IList<Duration> Duration { get;set; }

        public async Task OnGetAsync()
        {
            Duration = await _context.Duration.ToListAsync();
        }
    }
}
