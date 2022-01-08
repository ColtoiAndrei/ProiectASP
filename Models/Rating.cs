using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectASP.Models
{
    public class Rating
    {
        public int ID { get; set; }
        [Display(Name = "Rating")]
        [Required, StringLength(1, MinimumLength = 1, ErrorMessage = "Rating-ul trebuie sa fie format dintr-o singura cifra")]
        public string RatingName { get; set; }
        public ICollection<Movie> Movies { get; set; }
    }
}
