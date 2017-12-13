using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FunkyFadz.Models
{
    public class FunkyFadzListModel
    {
        public int FunkyFadzId { get; set; }

        public string FadType { get; set; }

        public int Year{ get; set; }

        [Display(Name = "Created")]
        public DateTimeOffset CreatedUtc { get; set; }

        public override string ToString() => $"[{FunkyFadzId}] {FadType}";
    }
}
