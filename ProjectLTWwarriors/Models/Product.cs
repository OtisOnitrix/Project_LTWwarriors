using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ProjectLTWwarriors.Models
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }

        // Cho phép trống
        public List<string> Storage { get; set; }

        public List<string> Colors { get; set; }

        public List<string> ImageUrls { get; set; }
    }
}