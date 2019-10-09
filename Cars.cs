using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CArsssss.Data
{
    public class Cars
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int CID { get; set; }
        [Display(Name = "Mustang")]
        public string Mustang { get; set; }
        [Display(Name = "Vantage")]

        public string Vantage { get; set; }
        [Display(Name = "Corvette")]
        public string Corvette { get; set; }

    }
}
