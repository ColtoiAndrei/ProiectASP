using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProiectASP.Models
{
    public class Movie
    {
        public int ID { get; set; }
        [Required, StringLength(25, MinimumLength = 3, ErrorMessage = "Numele filmului trebuie sa contina intre 3 si 25 litere")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }
        public int GenreID { get; set; }
        public Genre Genre { get; set; }
        public int DurationID { get; set; }
        public Duration Duration { get; set; }
        public int LanguageID { get; set; }
        public Language Language { get; set; }
        public int RatingID { get; set; }
        public Rating Rating { get; set; }
    }
}
