using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TrafficDB
{
    public class Lamb
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ID { get; set; }
        public string LambNumber { get; set; }
        public int LocationID { get; set; }
        public Location Location { get; set; }
        public WhichColor _WhichColor { get; set; }
        public DateTime Timer { get; set; } = DateTime.Now;
    }
    public enum WhichColor
    {
        red=0,
        yellow=1,
        green=2
    }
}
