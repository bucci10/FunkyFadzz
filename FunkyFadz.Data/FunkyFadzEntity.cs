using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyFadz.Data
{
    public class FunkyFadzEntity
    {
        [Key]
        public int FunkyFadzId { get; set; }

        [Required]
        public Guid OwnerId { get; set; }

        [Required]
        public string FadType { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }


        [Required]
        public DateTimeOffset CreatedUtc { get; set; }

        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
