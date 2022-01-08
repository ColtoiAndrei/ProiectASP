using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProiectASP.Models;

namespace ProiectASP.Data
{
    public class ProiectASPContext : DbContext
    {
        public ProiectASPContext (DbContextOptions<ProiectASPContext> options)
            : base(options)
        {
        }

        public DbSet<ProiectASP.Models.Movie> Movie { get; set; }

        public DbSet<ProiectASP.Models.Genre> Genre { get; set; }

        public DbSet<ProiectASP.Models.Duration> Duration { get; set; }

        public DbSet<ProiectASP.Models.Language> Language { get; set; }

        public DbSet<ProiectASP.Models.Rating> Rating { get; set; }
    }
}
