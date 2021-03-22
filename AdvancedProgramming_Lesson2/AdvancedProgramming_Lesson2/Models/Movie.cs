using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AdvancedProgramming_Lesson2.Models
{
    public class Movie
    {
        [Display(Name = "Identyfikator")]
        public int Id { get; set; }
        [Display(Name = "Tytuł")]
        public string Title { get; set; }

        [DataType(DataType.Date)]
        [Display(Name = "Data Wypuszczenia")]
        public DateTime ReleaseDate { get; set; }
        [Display(Name = "Rodzaj")]
        public string Genre { get; set; }
        [Display(Name = "Cena")]
        public decimal Price { get; set; }
    }
}
