using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Assignment3.Models
{
    public class Products

    {
        [Key]
        public int Id { get; set; }
        public int Code { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public string Color { get; set; }
        public string Dimension { get; set; }
        public string Description { get; set; }
        public string Brand { get; set; }
    }
}