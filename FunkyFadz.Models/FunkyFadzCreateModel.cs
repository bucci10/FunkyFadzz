using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyFadz.Models
{
    public class FunkyFadzCreateModel
    {
        [Required]
        [MinLength(2, ErrorMessage = "Please enter at least two characters.")]
        [MaxLength(250)]
        public string FadType { get; set; }

        [Required]
        [MaxLength(8000)]
        public string Description { get; set; }

        [Required]
        public int Year { get; set; }

        public override string ToString() => FadType;
    }
}
