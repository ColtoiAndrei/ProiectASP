using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectASP.Models
{
    public class Genre
    {
        public int ID { get; set; }
        [Display(Name = "Genre")]
        [Required, StringLength(15, MinimumLength = 2, ErrorMessage = "Genul filmului trebuie sa contina intre 2 si 15 litere")]
        public string GenreName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
