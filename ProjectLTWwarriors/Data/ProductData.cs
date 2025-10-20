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
                    Name = "iPhone 17 Pro Max",
                    Price = 37990000,
                    Storage = new List<string>{"256GB","512GB","1TB","2TB"},
                    Colors = new List<string> { "#003366", "#C0C0C0", "#FF4500"},
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/iphone-17-pro-blue-thumb-650x650.png",
                        "~/images_LandingPage/IP17ProMax.jpg"

                    }
                },

                new Product
                {
                    Id = 2,
                    Name = "iPhone 17 Pro",
                    Price = 34990000,
                    Storage = new List<string>{"256GB","512GB","1TB"},
                    Colors = new List<string> { "#FF4500", "#C0C0C0", "#003366" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/iphone-17-pro.png",
                        "~/images_LandingPage/new17pro.png"
                    }
                },

                new Product
                {
                    Id = 3,
                    Name = "iPhone Air 256GB",
                    Price = 31990000,
                    Storage = new List<string>{"256GB","512GB","1TB"},
                    Colors = new List<string> { "#F0F9FF", "#FFFCF5", "#FCFCFC", "#000000" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/iphone-17.png"
                    }
                },

                new Product
                {
                    Id = 4,
                    Name = "iPhone 17 256GB",
                    Price = 37990000,
                    Storage = new List<string>{"256GB","512GB"},
                    Colors = new List<string> { "#96AED1", "#DFCEEA", "#A9B689", "#F5F5F5", "#353839" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/iphone-air-xanh.png"
                    }
                },

                new Product
                {
                    Id = 5,
                    Name = "MacBook Air 13 inch M1",
                    Price = 19590000,
                    Storage = new List<string>{"X"},
                    Colors = new List<string> { "#D1D5D8" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/mac-air-m1-13-xam-new-650x650.png"
                    }
                },

                new Product
                {
                    Id = 6,
                    Name = "MacBook Air 13 inch M2 8GPU",
                    Price = 20090000,
                    Storage = new List<string>{"X"},
                    Colors = new List<string> { "#1D1D1F", "#D1C6B1" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/mac-air-m2-13-xanh-new-1-650x650.png"
                    }
                },

                new Product
                {
                    Id = 7,
                    Name = "MacBook Air 13 inch M4 16GB/256GB",
                    Price = 25590000,
                    Storage = new List<string>{"X"},
                    Colors = new List<string> { "#D1C6B1", "#A3C6D9", "#D1D5D8", "#1D1D1F" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/macbook-air-13-inch-m4-16gb-256gb-sac-70w-xanh-den-thumb-638903417001618599-650x650.png"
                    }
                },

                new Product
                {
                    Id = 8,
                    Name = "MacBook Air 13 inch M4 16GB/256GB Sạc 70W",
                    Price = 26190000,
                    Storage = new List<string>{"X"},
                    Colors = new List<string> { "#A3C6D9", "#1D1D1F", "#D1C6B1", "#D1D5D8" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/macbook-air-13-inch-m4-thumb-vang-650x650.png"
                    }
                },

                new Product
                {
                    Id = 9,
                    Name = "iPad A16 WiFi 128 GB",
                    Price = 8890000,
                    Storage = new List<string>{"128GB","256GB","512GB"},
                    Colors = new List<string> { "#F9E05E", "#A3C6D9", "#F8B6D1", "#D1D5D8" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/ipad-air-m3-11-inch-wifi-blue-thumb-650x650.png"
                    }
                },

                new Product
                {
                    Id = 10,
                    Name = "iPad mini 7 WiFi",
                    Price = 11790000,
                    Storage = new List<string>{"128GB","256GB","512GB"},
                    Colors = new List<string> { "#B7A2D4", "#A3C6D9", "#F4F4F5", "#3A3A3C" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/ipad-air-m3-11-inch-wifi-blue-thumb-650x650.png"
                    }
                },

                new Product
                {
                    Id = 11,
                    Name = "iPad Air M3 11 inch WiFi 128 GB",
                    Price = 13690000,
                    Storage = new List<string>{ "128GB","256GB","1TB"},
                    Colors = new List<string> { "#A3C6D9", "#B7A2D4", "#F4F4F5", "#3A3A3C" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/ipad-mini-7-wifi-purple-thumbtz-650x650.png"
                    }
                },

                new Product
                {
                    Id = 12,
                    Name = "iPad Pro M4 11 inch WiFi 256GB",
                    Price = 27290000,
                    Storage = new List<string>{"256GB","512GB","2TB"},
                    Colors = new List<string> { "#1C1C1E", "#D1D3D4" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/ipad-pro-11-inch-wifi-silver-thumb-650x650.png"
                    }
                },

                new Product
                {
                    Id = 13,
                    Name = "Apple Watch Series 11 GPS 42mm viền nhôm dây thể thao",
                    Price = 11490000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "#1C1C1E", "#F8D3C4", "#B7A2D4" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/apple-watch-series-11-42mm-vien-nhom-day-the-thao-vang-hong-thumb-650x650.png"
                    }
                },

                new Product
                {
                    Id = 14,
                    Name = "Apple Watch Series 11 GPS 46mm viền nhôm dây thể thao",
                    Price = 12350000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "#1C1C1E", "#F8D3C4", "#B7A2D4" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/apple-watch-series-11-46mm-vien-nhom-day-the-thao-den-thumb-650x650.png"
                    }
                },

                new Product
                {
                    Id = 15,
                    Name = "Apple Watch Series 11 GPS + Cellular 42mm viền nhôm dây thể thao",
                    Price = 14490000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "#1C1C1E", "#F8D3C4", "#B7A2D4" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/apple-watch-series-11-gps-cellular-vien-nhom-day-the-thao-vang-hong-thumb-650x650.png"
                    }
                },

                new Product
                {
                    Id = 16,
                    Name = "Apple Watch Series 11 GPS + Cellular 46mm viền nhôm dây thể thao",
                    Price = 15350000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "#1C1C1E", "#F8D3C4", "#B7A2D4" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/apple-watch-series-11-gps-cellular-vien-nhom-day-the-thao-xam-thumb-1-650x650.png"
                    }
                },

                

                new Product
                {
                    Id = 17,
                    Name = "EarPods jack cắm USB-C",
                    Price = 540000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "White"},
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/tai-nghe-co-day-apple-mtjy3-thumb-650x650.png"
                    }
                },

                new Product
                {
                    Id = 18,
                    Name = "AirPods 4",
                    Price = 3190000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "White"},
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/airpods-4-thumb-1-650x650.png"
                    }
                },

                new Product
                {
                    Id = 19,
                    Name = "AirPods Pro (2nd Gen) USB-C",
                    Price = 5590000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "White" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/tai-nghe-bluetooth-airpods-pro-2nd-gen-usb-c-charge-apple-thumb-12-1-650x650.png"
                    }
                },

                new Product
                {
                    Id = 20,
                    Name = "Loa Bluetooth Marshall Emberton III",
                    Price = 5300000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "#1C1C1E", "#A3B29C", "#F1F1F1" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/loa-bluetooth-marshall-emberton-iii-650x650.png"
                    }
                },

                new Product
                {
                    Id = 21,
                    Name = "Adapter sạc Apple USB-C 20W",
                    Price = 540000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "White" },
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/adapter-sac-type-c-20w-cho-iphone-ipad-apple-mhje3-101021-023343-650x650.png"
                    }
                },

                new Product
                {
                    Id = 22,
                    Name = "Apple Pencil Pro",
                    Price = 3190000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "White"},
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/apple-pencil-pro-650x650.png"
                    }
                },

                new Product
                {
                    Id = 23,
                    Name = "Cáp sạc Type C - Type C 1m",
                    Price = 540000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "White"},
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/cap-type-c-type-c-1m-apple-mqkj3-thumb-5-650x650.png"
                    }
                },

                new Product
                {
                    Id = 24,
                    Name = "Bao da Smart Folio cho iPad Pro M4 11 inch",
                    Price = 2190000,
                    Storage = new List < string > { "X" },
                    Colors = new List<string> { "#4A6A8C", "#F2F2F7", "#1C1C1E"},
                    ImageUrls = new List<string>
                    {
                        "~/images_LandingPage/bao-da-smart-folio-cho-ipad-pro-m4-11-inch-thumb-650x650.png"
                    }
                },


            };
        }
    }
}