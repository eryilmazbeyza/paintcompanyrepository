using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintcompanyrepository.Model
{
    public class SolventBasedPaint
    {
        [Key]
        public int SolventId { get; set; }
        public string SPName { get; set;}
        public string Applicationarea { get; set;}
        public int Amount { get; set; }
        public decimal Expenses { get; set; }
        public int ColorId { get; set; }
        [ForeignKey("ColorId")]
        public Color Color { get; set; }
    }
}
