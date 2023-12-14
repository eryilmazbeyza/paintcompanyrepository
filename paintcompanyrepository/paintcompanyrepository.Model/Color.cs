using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace paintcompanyrepository.Model
{
    public class Color
    {
        [Key]
        public int ColorId { get; set; }
        public string PrimaryColors { get; set; }
        public string SecondaryColors { get; set; }
        public string TertiaryColors { get; set; }
        public bool Effects {  get; set; }
        public int ChemicalId { get; set; }

        [ForeignKey("ChemicalId")]
        public Chemical Chemical { get; set; }


    }
}
