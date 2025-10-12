using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using ProjectLTWwarriors.Models;

namespace ProjectLTWwarriors.Data
{
    public class ProductData
    {
        public static List<Product> GetAllProducts()
        {
            return new List<Product>
            {
                new Product
                {
                    Id = 1,
                    Name = "iPhone 13 Pro Max",
                    Price = 1099.99m,
                    Storage = "128GB",
                    Colors = new List<string> { "Silver", "Graphite", "Gold", "Sierra Blue" },
                    ImageUrls = new List<string>
                    {
                        "~/Content/images/sony-xperia-1-iii-1.jpg",
                        "~/Content/images/sony-xperia-1-iii-2.jpg",
                        "~/Content/images/sony-xperia-1-iii-3.jpg"
                    }
                },
                new Product
                {
                    Id = 2,
                    Name = "Samsung Galaxy S21 Ultra",
                    Price = 1199.99m,
                    Storage = "256GB",
                    Colors = new List<string> { "Phantom Black", "Phantom Silver" }
                },
                new Product
                {
                    Id = 3,
                    Name = "Google Pixel 6 Pro",
                    Price = 899.99m,
                    Storage = "128GB",
                    Colors = new List<string> { "Stormy Black", "Cloudy White", "Sorta Sunny" }
                },
                new Product
                {
                    Id = 4,
                    Name = "OnePlus 9 Pro",
                    Price = 969.99m,
                    Storage = "256GB",
                    Colors = new List<string> { "Morning Mist", "Pine Green", "Stellar Black" }
                },
                new Product
                {
                    Id = 5,
                    Name = "Sony Xperia 1 III",
                    Price = 1299.99m,
                    Storage = "256GB",
                    Colors = new List<string> { "Frosted Black", "Frosted Purple" }
                }
            };
        }
    }
}