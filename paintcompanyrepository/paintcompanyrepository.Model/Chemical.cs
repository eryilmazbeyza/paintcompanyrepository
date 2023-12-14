using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintcompanyrepository.Model
{
    public class Chemical
    {
        [Key]
        public int ChemicalId { get; set; }
        public string ChemicalName { get; set; }
        public string Ingredients { get; set; }
        public int Amounts { get; set; }
        public decimal Expenses { get; set; }

    }
}
