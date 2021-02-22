using GreenElectricCarsDk.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GreenElectricCarsDk.Models
{
    public class SeedData
    {
        public static void Initialize(IServiceProvider service)
        {
            using (var context = new ApplicationDbContext(service.GetRequiredService<DbContextOptions<ApplicationDbContext>>()))
           {
                // Fill with data if DB is null
                if (!context.Cars.Any())
                {
                    context.Cars.AddRange(
                     new Car
                     {
                         Name = "Tesla Model 3",
                         Price = 200000,
                         IsPreferredCar = true,
                         Stock = 1,
                         CategoryId = 1,
                         ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                         LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                         ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                         ImageThumbnailUrl = "car1.jpg"
                     },
                   new Car
                   {
                       Name = "Tesla Model 4",
                       Price = 300000,
                       IsPreferredCar = true,
                       Stock = 1,
                       CategoryId = 2,
                       ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                       LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                       ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                       ImageThumbnailUrl = "car2.jpg"
                   },
                    new Car
                    {
                        Name = "Toyata",
                        Price = 400000,
                        IsPreferredCar = true,
                        Stock = 1,
                        CategoryId =3 ,
                        ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                        LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                        ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                        ImageThumbnailUrl = "car3.jpg"
                    },
                     new Car
                     {
                         Name = "Mitsubishi Outlander PHEV",
                         Price = 500000,
                         IsPreferredCar = true,
                         Stock = 1,
                         CategoryId = 1,
                         ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                         LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                         ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                         ImageThumbnailUrl = "car4.jpg"
                     },
                        new Car
                        {
                            Name = "OPEL Corsa",
                            Price = 600000,
                            IsPreferredCar = true,
                            Stock = 1,
                            CategoryId = 2,
                            ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                            LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                            ImageThumbnailUrl = "car4.jpg"
                        },
                        new Car
                        {
                            Name = "Citron",
                            Price = 400000,
                            IsPreferredCar = true,
                            Stock = 1,
                            CategoryId = 3,
                            ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                            LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                            ImageThumbnailUrl = "car4.jpg"
                        },
                        new Car
                        {
                            Name = "Audi",
                            Price = 300000,
                            IsPreferredCar = true,
                            Stock = 1,
                            CategoryId = 1,
                            ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                            LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                            ImageThumbnailUrl = "car4.jpg"
                        },
                        new Car
                        {
                            Name = "Nissan",
                            Price = 700000,
                            IsPreferredCar = true,
                            Stock = 1,
                            CategoryId = 2,
                            ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                            LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                            ImageThumbnailUrl = "car4.jpg"
                        },
                        new Car
                        {
                            Name = "Renault",
                            Price = 200000,
                            IsPreferredCar = true,
                            Stock = 1,
                            CategoryId = 3,
                            ShortDescribtion = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla",
                            LongDescription = "The Tesla Model 3 is an electric four-door fastback sedan developed by Tesla.[6] The Model 3 Standard Range Plus version delivers an EPA-rated all-electric range of 263 miles (423 km) and the Long",
                            ImageUrl = "https://en.wikipedia.org/wiki/Tesla_Model_3#/media/File:2019_Tesla_Model_3_Performance_AWD_Front.jpg",
                            ImageThumbnailUrl = "car4.jpg"
                        }
                     );
                }
                // Fill with data if DB is null
                if (!context.Categories.Any())
                {
                    context.Categories.AddRange(
                    new Category() { CategoryId=1, CategoryName = "NonEco-Friendly", CategoryDescription = "CO2 emmision" },
                    new Category() { CategoryId=2,CategoryName = "Eco-Friendly", CategoryDescription = "Less CO2 emmision" },
                    new Category() { CategoryId=3, CategoryName = "All-Cars", CategoryDescription = "All Type of Cars" });

                }

                if (!context.Cars.Any() || !context.Categories.Any())
                {
                    // Save into DB
                    context.SaveChanges();
                }


            }

        }
    }
}
