using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcLotion.Models
{
    public class Lotion
    {
        public int Id { get; set; }
        public string LotionName { get; set; }
        public string  LotionType { get; set; }
        public string Color { get; set; }
        
        [DataType(DataType.Date)]
        public DateTime LaunchDate { get; set; }
        public decimal Volume { get; set; }
        public decimal Price { get; set; }
        public decimal Rating { get; set; }
    }
}
