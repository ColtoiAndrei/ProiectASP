using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectASP.Models
{
    public class Duration
    {
        public int ID { get; set; }
        [Display(Name = "Duration")]
        [Required, StringLength(3, MinimumLength = 2, ErrorMessage = "Durata filmului trebuie sa contina intre 2 si 3 cifre")]
        public string DurationName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
