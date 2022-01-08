using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectASP.Models
{
    public class Language
    {
        public int ID { get; set; }
        [Display(Name = "Language")]
        [RegularExpression(@"^[A-Z][a-z]+$", ErrorMessage = "Limba trebuie sa fie de forma 'Limba'")]
        public string LanguageName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
