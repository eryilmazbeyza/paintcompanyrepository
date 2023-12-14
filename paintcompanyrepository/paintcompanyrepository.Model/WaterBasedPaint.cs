using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintcompanyrepository.Model
{
    public class WaterBasedPaint
    {
        [Key]
        public int WaterId { get; set; }
        public string WPName { get; set; }
        public string Applicationarea { get; set; }
        public int Amount { get; set; }
        public decimal Expenses { get; set; }
        public int ColorId { get; set; }

        [ForeignKey("ColorId")]

        public Color Color { get; set; }
       
    }
}
