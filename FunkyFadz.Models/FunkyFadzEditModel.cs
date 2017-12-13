using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyFadz.Models
{
    public class FunkyFadzEditModel
    {
        public int FunkyFadzId { get; set; }
        public string FadType { get; set; }
        public string Description { get; set; }
        public int Year { get; set; }
        public DateTimeOffset? ModifiedUtc { get; set; }
    }
}
