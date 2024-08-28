using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Models
{
    public class ProductModel
    {
        //public string Name { get; set; }
        //public decimal Price { get; set; }
        //public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [Range(0.01, 1000.00)]
        public decimal Price { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
    }
}
