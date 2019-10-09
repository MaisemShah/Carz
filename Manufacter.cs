using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CArsssss.Data
{
    public class Manufacter
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int  MID { get; set; }
        public string Ford { get; set; }

        public string AStonMartin { get; set; }

        public string Cheverolet { get; set; }
        [ForeignKey("CID")]
        public Cars CarsID { get; set; }
    }
}
