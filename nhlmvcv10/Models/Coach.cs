using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NHLPlayv3.Models
{
    public class Coach
    {
        [Key]
        public int id { get; set; }
        public string lastname { get; set; }
        public string firstname { get; set; }
        public DateTime bdate {get; set; }
        }
}
